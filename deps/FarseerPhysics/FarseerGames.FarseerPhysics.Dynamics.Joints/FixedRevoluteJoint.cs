using System;
using FarseerGames.FarseerPhysics.Mathematics;
using Microsoft.Xna.Framework;

namespace FarseerGames.FarseerPhysics.Dynamics.Joints;

public class FixedRevoluteJoint : Joint
{
	private Vector2 _accumulatedImpulse;

	private Vector2 _anchor;

	private Matrix _b;

	private Body _body;

	private Vector2 _localAnchor;

	private Matrix _matrix;

	private float _maxImpulse = float.MaxValue;

	private Vector2 _r1;

	private Vector2 _velocityBias;

	private Vector2 _dv;

	private Vector2 _dvBias;

	private Vector2 _impulse;

	private float _bodyInverseMass;

	private float _bodyInverseMomentOfInertia;

	private Matrix _bodyMatrixTemp;

	private float _floatTemp1;

	private Matrix _k;

	private Matrix _k1;

	private Matrix _k2;

	private Vector2 _vectorTemp1 = Vector2.Zero;

	private Vector2 _vectorTemp2 = Vector2.Zero;

	public Body Body
	{
		get
		{
			return _body;
		}
		set
		{
			_body = value;
		}
	}

	public float MaxImpulse
	{
		get
		{
			return _maxImpulse;
		}
		set
		{
			_maxImpulse = value;
		}
	}

	public Vector2 Anchor
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _anchor;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			_anchor = value;
			SetAnchor(_anchor);
		}
	}

	public event FixedJointDelegate JointUpdated;

	public FixedRevoluteJoint()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		BiasFactor = 0.8f;
	}

	public FixedRevoluteJoint(Body body, Vector2 anchor)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		_body = body;
		_anchor = anchor;
		_accumulatedImpulse = Vector2.Zero;
		body.GetLocalPosition(ref anchor, out _localAnchor);
		BiasFactor = 0.8f;
	}

	public void SetAnchor(Vector2 anchor)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_anchor = anchor;
		if (_body == null)
		{
			throw new ArgumentNullException("anchor", "Body must be set prior to setting the anchor of the Revolute Joint");
		}
		_body.GetLocalPosition(ref anchor, out _localAnchor);
	}

	public override void Validate()
	{
		if (_body.IsDisposed)
		{
			Dispose();
		}
	}

	public override void PreStep(float inverseDt)
	{
		if (!_body.isStatic && _body.Enabled)
		{
			_bodyInverseMass = _body.inverseMass;
			_bodyInverseMomentOfInertia = _body.inverseMomentOfInertia;
			_body.GetBodyMatrix(out _bodyMatrixTemp);
			Vector2.TransformNormal(ref _localAnchor, ref _bodyMatrixTemp, out _r1);
			_k1.M11 = _bodyInverseMass;
			_k1.M12 = 0f;
			_k1.M21 = 0f;
			_k1.M22 = _bodyInverseMass;
			_k2.M11 = _bodyInverseMomentOfInertia * _r1.Y * _r1.Y;
			_k2.M12 = (0f - _bodyInverseMomentOfInertia) * _r1.X * _r1.Y;
			_k2.M21 = (0f - _bodyInverseMomentOfInertia) * _r1.X * _r1.Y;
			_k2.M22 = _bodyInverseMomentOfInertia * _r1.X * _r1.X;
			Matrix.Add(ref _k1, ref _k2, out _k);
			ref Matrix k = ref _k;
			k.M11 += Softness;
			ref Matrix k2 = ref _k;
			k2.M12 += Softness;
			MatrixInvert2D(ref _k, out _matrix);
			Vector2.Add(ref _body.position, ref _r1, out _vectorTemp1);
			Vector2.Subtract(ref _anchor, ref _vectorTemp1, out _vectorTemp2);
			Vector2.Multiply(ref _vectorTemp2, (0f - BiasFactor) * inverseDt, out _velocityBias);
			base.JointError = _vectorTemp2.Length();
			_vectorTemp1.X = 0f - _accumulatedImpulse.X;
			_vectorTemp1.Y = 0f - _accumulatedImpulse.Y;
			if (_maxImpulse < float.MaxValue)
			{
				Calculator.Truncate(ref _vectorTemp1, _maxImpulse, out _vectorTemp1);
			}
			_body.ApplyImmediateImpulse(ref _vectorTemp1);
			Calculator.Cross(ref _r1, ref _vectorTemp1, out _floatTemp1);
			_body.ApplyAngularImpulse(_floatTemp1);
		}
	}

	private void MatrixInvert2D(ref Matrix matrix, out Matrix invertedMatrix)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		float m = matrix.M11;
		float m2 = matrix.M12;
		float m3 = matrix.M21;
		float m4 = matrix.M22;
		float num = m * m4 - m2 * m3;
		num = 1f / num;
		_b.M11 = num * m4;
		_b.M12 = (0f - num) * m2;
		_b.M21 = (0f - num) * m3;
		_b.M22 = num * m;
		invertedMatrix = _b;
	}

	public override void Update()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		base.Update();
		if (_body.isStatic || !_body.Enabled)
		{
			return;
		}
		Calculator.Cross(ref _body.AngularVelocity, ref _r1, out _vectorTemp1);
		Vector2.Add(ref _body.LinearVelocity, ref _vectorTemp1, out _dv);
		_dv = -_dv;
		Vector2.Subtract(ref _velocityBias, ref _dv, out _vectorTemp1);
		Vector2.Multiply(ref _accumulatedImpulse, Softness, out _vectorTemp2);
		Vector2.Subtract(ref _vectorTemp1, ref _vectorTemp2, out _dvBias);
		Vector2.Transform(ref _dvBias, ref _matrix, out _impulse);
		Vector2.Add(ref _accumulatedImpulse, ref _impulse, out _accumulatedImpulse);
		if (_vectorTemp1 != Vector2.Zero)
		{
			_vectorTemp1.X = 0f - _impulse.X;
			_vectorTemp1.Y = 0f - _impulse.Y;
			if (_maxImpulse < float.MaxValue)
			{
				Calculator.Truncate(ref _vectorTemp1, _maxImpulse, out _vectorTemp1);
			}
			_body.ApplyImmediateImpulse(ref _vectorTemp1);
			Calculator.Cross(ref _r1, ref _vectorTemp1, out _floatTemp1);
			_body.ApplyAngularImpulse(_floatTemp1);
			if (this.JointUpdated != null)
			{
				this.JointUpdated(this, _body);
			}
		}
	}
}
