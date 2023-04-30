using System;
using Microsoft.Xna.Framework;
using Physics;
using Renderer;
using Scene;

namespace PlayerData;

public class HospitalScene
{
	private const int FLOOR_WIDTH = 3000;

	private Player m_baby;

	private PhysicalRepresentation m_obj;

	private PhysicalRepresentation m_objRoof;

	private PhysicalRepresentation m_obj2;

	private PhysicalRepresentation m_objRoof2;

	private RoomManager m_roomManager;

	public HospitalScene()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		m_obj = PhysicsObjectManager.CreatePhysicalRepresentation(new Rectangle(0, 668, 3000, 100), PhysicsObjectManager.WallCollisionGroup());
		m_obj.Static = true;
		m_obj.FrictionCoeff = 0.5f;
		m_obj.Bounciness = 0.5f;
		m_obj.Mass = 1f;
		m_objRoof = PhysicsObjectManager.CreatePhysicalRepresentation(new Rectangle(0, -232, 3000, 100), PhysicsObjectManager.WallCollisionGroup());
		m_objRoof.Static = true;
		m_objRoof.FrictionCoeff = 0f;
		m_objRoof.Bounciness = 0.5f;
		m_objRoof.Mass = 1f;
		m_obj2 = PhysicsObjectManager.CreatePhysicalRepresentation(new Rectangle(3000, 668, 3000, 100), PhysicsObjectManager.WallCollisionGroup());
		m_obj2.Static = true;
		m_obj2.FrictionCoeff = 0.5f;
		m_obj2.Bounciness = 0.5f;
		m_obj2.Mass = 1f;
		m_objRoof2 = PhysicsObjectManager.CreatePhysicalRepresentation(new Rectangle(3000, -232, 3000, 100), PhysicsObjectManager.WallCollisionGroup());
		m_objRoof2.Static = true;
		m_objRoof2.FrictionCoeff = 0f;
		m_objRoof2.Bounciness = 0.5f;
		m_objRoof2.Mass = 1f;
		m_baby = new Player();
		m_roomManager = new RoomManager();
	}

	public PropPool GetPropPool()
	{
		return m_roomManager.GetPropPool();
	}

	public void Initialize()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		m_baby.Initialize();
		m_roomManager.Initialize();
		m_obj.Position = new Vector2(1500f, m_obj.Position.Y);
		m_objRoof.Position = new Vector2(1500f, m_objRoof.Position.Y);
		m_obj2.Position = new Vector2(m_obj.Position.X + 3000f, m_obj.Position.Y);
		m_objRoof2.Position = new Vector2(m_objRoof.Position.X + 3000f, m_objRoof.Position.Y);
		m_obj.ResetSimulation();
		m_objRoof.ResetSimulation();
		m_obj2.ResetSimulation();
		m_objRoof2.ResetSimulation();
	}

	public void Update(TimeTracker gameTime, bool isActive)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		Vector2 position = m_baby.Position;
        position = new Vector2(Math.Max(position.X + 200f, SceneRenderer.GetScreenDim().X / 2f), Math.Min(position.Y + 200f, SceneRenderer.GetScreenDim().Y / 2f));
		SceneRenderer.MoveCamera(position, 0f, 1f);
		m_baby.Update(gameTime, isActive);
		if (SceneRenderer.GetCameraPosition().X > m_obj2.Position.X)
		{
			PhysicalRepresentation obj = m_obj;
			PhysicalRepresentation objRoof = m_objRoof;
			Vector2 position2 = m_obj2.Position;
			Vector2 position3 = m_objRoof2.Position;
			m_obj = m_obj2;
			m_objRoof = m_objRoof2;
			m_obj.GetGeom().Body.ResetDynamics();
			m_objRoof.GetGeom().Body.ResetDynamics();
			m_obj.Position = position2;
			m_objRoof.Position = position3;
			m_obj2 = obj;
			m_obj2.GetGeom().Body.ResetDynamics();
			m_obj2.Position = m_obj.Position + new Vector2(3000f, 0f);
			m_objRoof2 = objRoof;
			m_objRoof2.GetGeom().Body.ResetDynamics();
			m_objRoof2.Position = m_objRoof.Position + new Vector2(3000f, 0f);
		}
		if (SceneRenderer.GetCameraPosition().X < m_obj.Position.X)
		{
			PhysicalRepresentation obj2 = m_obj;
			PhysicalRepresentation objRoof2 = m_objRoof;
			Vector2 position4 = m_obj.Position;
			Vector2 position5 = m_objRoof.Position;
			m_obj = m_obj2;
			m_obj.GetGeom().Body.ResetDynamics();
			m_obj.Position = obj2.Position - new Vector2(3000f, 0f);
			m_objRoof = m_objRoof2;
			m_objRoof.GetGeom().Body.ResetDynamics();
			m_objRoof.Position = objRoof2.Position - new Vector2(3000f, 0f);
			m_obj2 = obj2;
			m_objRoof2 = objRoof2;
			m_obj2.GetGeom().Body.ResetDynamics();
			m_objRoof2.GetGeom().Body.ResetDynamics();
			m_obj2.Position = position4;
			m_objRoof2.Position = position5;
		}
		m_roomManager.Update(gameTime, m_baby);
	}

	public void Draw(TimeTracker gameTime, bool activeScene)
	{
		if (activeScene)
		{
			m_baby.Draw(gameTime);
		}
		m_roomManager.Draw(gameTime);
	}

	public void HandleInput(TimeTracker gameTime)
	{
		m_baby.HandleInput(gameTime);
	}

	public void Launch(Vector2 angle, float power)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		m_baby.Launch(angle, power);
	}

	public bool IsComplete()
	{
		return m_baby.IsStopped();
	}

	public Player GetPlayer()
	{
		return m_baby;
	}
}
