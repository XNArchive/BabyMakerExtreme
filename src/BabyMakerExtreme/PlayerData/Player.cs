using System;
using System.Collections.Generic;
using System.Text;
using BabyMaker;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Physics;
using Renderer;
using Scene;

namespace PlayerData;

public class Player
{
	private const int PARTICLE_SPAWN_TIME = 60;

	private const int DIVE_VAL = 5000;

	private const int DIVE_TIME = 1000;

	private const int LEAP_TIME = 500;

	private const int ROOF_POS = -50;

	private const int FLOOR_POS = 600;

	private const int SCORE_COLLIDE_ITER = 30;

	private List<PhysicalRepresentation> m_objs;

	private List<Vector2> m_vSavedVel;

	private bool m_bRevertData;

	private Vector2 m_vVelMod;

	private PhysicsOutfit m_physicsOutfit;

	private bool m_bRevertVel;

	private List<AwardPopup> m_popups;

	private List<AwardPopup> m_popupRemoves;

	private int m_iDiveCharge;

	private int m_iParticleTimer;

	private List<Vector2> m_distTravelledPerSec;

	private bool m_bBabyStopped;

	private bool m_bBabyLaunched;

	private Dictionary<int, int> m_typeCounts;

	private List<RenderSprite> m_sprites;

	private List<RenderSprite> m_propDecor;

	private List<int> m_propDecorSprite;

	private List<bool> m_propDecorEnabled;

	private string m_sex;

	private bool m_bBadBreathing;

	private bool m_bBadAiming;

	private bool m_bAimedHigh;

	private bool m_bBadPushing;

	private SoundEffect m_popSound;

	private bool m_bAvatar;

	private bool m_bCanDive;

	private bool m_bCanLeap;

	private int m_iLeapTimer;

	private int m_iDiveTimer;

	private RenderSprite m_diveSpr;

	private RenderSprite m_boostSpr;

	private RenderSprite m_flare1;

	private RenderSprite m_flare2;

	private int m_iLastDistance;

	private int m_iLastScore;

	private StringBuilder m_MutatedDistanceString;

	private char[] m_distanceCharArray;

	private StringBuilder m_MutatedScoreString;

	private char[] m_scoreCharArray;

	private string m_DistanceString;

	private string m_ScoreString;

	private int m_iCollisionPoints;

	//public bool Avatar
	//{
	//	get
	//	{
	//		return m_bAvatar;
	//	}
	//	set
	//	{
	//		if (value != m_bAvatar && value)
	//		{
	//			Game1.LoadAvatar();
	//		}
	//		else if (value != m_bAvatar)
	//		{
	//			Game1.ResetAvatar();
	//		}
	//		m_bAvatar = value;
	//	}
	//}

	public bool BadBreathing
	{
		get
		{
			return m_bBadBreathing;
		}
		set
		{
			m_bBadBreathing = value;
		}
	}

	public bool BadAiming
	{
		get
		{
			return m_bBadAiming;
		}
		set
		{
			m_bBadAiming = value;
		}
	}

	public bool AimedHigh
	{
		get
		{
			return m_bAimedHigh;
		}
		set
		{
			m_bAimedHigh = value;
		}
	}

	public bool BadPushing
	{
		get
		{
			return m_bBadPushing;
		}
		set
		{
			m_bBadPushing = value;
		}
	}

	public int DistanceTravelled => (int)(m_sprites[0].Position.X / 75f);

	public Vector2 Position => m_sprites[0].Position;

	public Player()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		m_DistanceString = " feet";
		m_ScoreString = " points";
		m_physicsOutfit = new PhysicsOutfit(1);
		PropGenerator.CreateBaby(m_physicsOutfit);
		m_objs = m_physicsOutfit.GetPhysicsObjects();
		m_physicsOutfit.ResetToPosition(new Vector2(100f, 480f));
		m_physicsOutfit.SetDepth(100f);
		InitPropsDecor();
		Initialize();
		for (int i = 0; i < m_objs.Count; i++)
		{
			m_objs[i].AirDrag = 0f;
			m_objs[i].Bounciness = 0.2f;
			m_objs[i].FrictionCoeff = 0.5f;
			m_objs[i].Mass = 1f;
			m_objs[i].CollisionCategory = PhysicsObjectManager.PlayerCollisionGroup();
			PhysicsObjectManager.AddPlayerGeom(m_objs[i], this);
		}
		m_popSound = SoundManager.GetSoundEffect("sounds/pop");
		m_bAvatar = false;
		m_iLastDistance = 0;
		m_iLastScore = 0;
	}

	public void InitPropsDecor()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		m_sprites = m_physicsOutfit.GetSprites(0);
		m_propDecor = new List<RenderSprite>();
		m_propDecorEnabled = new List<bool>();
		m_propDecorSprite = new List<int>();
		m_propDecor.Add(SpriteManager.GetSprite("images/babyProps", new Rectangle(25, 5, 82, 84), default(Vector2), m_sprites[1].Depth + 0.0005f));
		m_propDecor.Add(SpriteManager.GetSprite("images/babyProps", new Rectangle(296, 5, 82, 84), default(Vector2), m_sprites[1].Depth + 0.0005f));
		m_propDecor.Add(SpriteManager.GetSprite("images/babyProps", new Rectangle(112, 5, 82, 84), default(Vector2), m_sprites[1].Depth + 0.0004f));
		m_propDecor.Add(SpriteManager.GetSprite("images/babyProps", new Rectangle(204, 5, 82, 84), default(Vector2), m_sprites[1].Depth + 0.0006f));
		m_propDecorSprite.Add(1);
		m_propDecorSprite.Add(1);
		m_propDecorSprite.Add(1);
		m_propDecorSprite.Add(1);
		m_propDecorEnabled.Add(item: false);
		m_propDecorEnabled.Add(item: false);
		m_propDecorEnabled.Add(item: false);
		m_propDecorEnabled.Add(item: false);
		m_propDecor.Add(SpriteManager.GetSprite("images/babyProps", new Rectangle(13, 99, 92, 76), default(Vector2), m_sprites[3].Depth + 0.0001f));
		m_propDecor.Add(SpriteManager.GetSprite("images/babyProps", new Rectangle(13, 181, 92, 76), default(Vector2), m_sprites[3].Depth + 0.0001f));
		m_propDecorSprite.Add(3);
		m_propDecorSprite.Add(3);
		m_propDecorEnabled.Add(item: false);
		m_propDecorEnabled.Add(item: false);
		m_propDecor.Add(SpriteManager.GetSprite("images/babyProps", new Rectangle(122, 95, 100, 106), default(Vector2), m_sprites[0].Depth + 0.0001f));
		m_propDecor.Add(SpriteManager.GetSprite("images/babyProps", new Rectangle(122, 211, 100, 106), default(Vector2), m_sprites[0].Depth + 0.0001f));
		m_propDecorSprite.Add(0);
		m_propDecorSprite.Add(0);
		m_propDecorEnabled.Add(item: false);
		m_propDecorEnabled.Add(item: false);
		m_propDecor.Add(SpriteManager.GetSprite("images/babyProps", new Rectangle(230, 105, 83, 89), default(Vector2), m_sprites[2].Depth + 0.0001f));
		m_propDecor.Add(SpriteManager.GetSprite("images/babyProps", new Rectangle(228, 106, 83, 87), default(Vector2), m_sprites[4].Depth + 0.0001f));
		m_propDecorSprite.Add(2);
		m_propDecorSprite.Add(4);
		m_propDecorEnabled.Add(item: false);
		m_propDecorEnabled.Add(item: false);
		m_sex = "boy";
	}

	public List<bool> GetEnabledDecor()
	{
		return m_propDecorEnabled;
	}

	public string GetSex()
	{
		return m_sex;
	}

	public void Initialize()
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		if (SceneRenderer.GetRand(0f, 1f) < 0.5f || (m_bAvatar /*&& Game1.GetAvatar().IsMale()*/))
		{
			m_sex = "boy";
			if (m_propDecorEnabled[0] || m_propDecorEnabled[1])
			{
				m_propDecorEnabled[0] = true;
				m_propDecorEnabled[1] = false;
			}
		}
		else
		{
			m_sex = "girl";
			if (m_propDecorEnabled[0] || m_propDecorEnabled[1])
			{
				m_propDecorEnabled[0] = false;
				m_propDecorEnabled[1] = true;
			}
		}
		m_physicsOutfit.ResetToPosition(new Vector2(100f, 477f));
		m_physicsOutfit.RemoveStatic();
		m_bRevertData = false;
		m_vSavedVel = new List<Vector2>();
		for (int i = 0; i < m_objs.Count; i++)
		{
			m_vSavedVel.Add(default(Vector2));
		}
		m_vVelMod = default(Vector2);
		m_bRevertVel = false;
		m_popups = new List<AwardPopup>();
		m_popupRemoves = new List<AwardPopup>();
		m_diveSpr = SpriteManager.GetSprite("images/UI/diveButton", default(Vector2), DepthConsts.LOGO_DEPTH);
		m_diveSpr.Alpha = 0f;
		m_boostSpr = SpriteManager.GetSprite("images/UI/boostButton", default(Vector2), DepthConsts.LOGO_DEPTH);
		m_boostSpr.Alpha = 0f;
		m_flare1 = SpriteManager.GetSprite("images/UI/flare", default(Vector2), DepthConsts.LOGO_DEPTH + 1f);
		m_flare1.Alpha = 0f;
		m_flare1.SurfaceScale = new Vector2(200f, 150f);
		m_flare2 = SpriteManager.GetSprite("images/UI/flare", default(Vector2), DepthConsts.LOGO_DEPTH + 1f);
		m_flare2.Alpha = 0f;
		m_flare2.SurfaceScale = new Vector2(200f, 150f);
		m_iParticleTimer = 0;
		m_distTravelledPerSec = new List<Vector2>();
		m_bBabyStopped = false;
		m_bBabyLaunched = false;
		m_typeCounts = new Dictionary<int, int>();
		m_bBadBreathing = false;
		m_bBadAiming = false;
		m_bAimedHigh = false;
		m_bBadPushing = false;
		m_bCanDive = false;
		m_bCanLeap = false;
		m_iLeapTimer = 0;
		m_iDiveTimer = 0;
		m_iLastDistance = 0;
		m_MutatedDistanceString = new StringBuilder("0", 32);
		m_distanceCharArray = new char[32];
		m_distanceCharArray[0] = '\0';
		m_MutatedScoreString = new StringBuilder("0", 32);
		m_scoreCharArray = new char[32];
		m_scoreCharArray[0] = '\0';
		m_iCollisionPoints = 0;
	}

	private List<PhysicalRepresentation> GetPhysicsObj()
	{
		return m_objs;
	}

	public void Launch(Vector2 angle, float pow)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		SoundManager.AddSoundToPlay(m_popSound, Math.Max(0.5f, Math.Min(pow / 1000f, 1f)), SceneRenderer.GetRand(-0.2f, 0.2f), 0);
		for (int i = 0; i < m_objs.Count; i++)
		{
			m_objs[i].ApplyImpulse(angle * pow);
		}
		m_distTravelledPerSec.Clear();
		m_bBabyStopped = false;
		m_bBabyLaunched = true;
	}

	public void Update(TimeTracker gameTime, bool isActive)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		m_physicsOutfit.Update(gameTime);
		Vector2 val = default(Vector2);
		for (int i = 0; i < m_objs.Count; i++)
		{
			val += m_objs[i].Velocity;
		}
		val /= (float)m_objs.Count;
		float num = 1000 + Math.Min(1, DistanceTravelled / 2000) * 1000;
		float num2 = 1f + 0.5f * ((1000f - num) / 1000f);
		if (m_bRevertData)
		{
			m_bRevertData = false;
			for (int j = 0; j < m_objs.Count; j++)
			{
				m_objs[j].Velocity = m_vSavedVel[j];
			}
			float num3 = Math.Max((num - Math.Max(0f, val.X)) / num * 400f, 0f) * num2;
			if (val.Y > 0f)
			{
				for (int k = 0; k < m_objs.Count; k++)
				{
					float num4 = Math.Max(-400f, Math.Min(-0.4f * m_objs[k].Velocity.Y, -150f));
					m_objs[k].Velocity = new Vector2(m_objs[k].Velocity.X + num3, num4);
				}
				val.Y = 0f - val.Y;
			}
			else
			{
				for (int l = 0; l < m_objs.Count; l++)
				{
					float num5 = Math.Min(m_objs[l].Velocity.Y, -150f);
					m_objs[l].Velocity = new Vector2(m_objs[l].Velocity.X + num3, num5);
				}
			}
		}
		if (val.Y <= 0f)
		{
			m_vVelMod = default(Vector2);
		}
		if (m_bRevertVel)
		{
			for (int m = 0; m < m_objs.Count; m++)
			{
				PhysicalRepresentation physicalRepresentation = m_objs[m];
				physicalRepresentation.Velocity -= m_vVelMod;
			}
			m_vVelMod = default(Vector2);
			m_bRevertVel = false;
		}
		for (int n = 0; n < m_popups.Count; n++)
		{
			m_popups[n].Update(gameTime);
			if (!m_popups[n].IsActive())
			{
				m_popupRemoves.Add(m_popups[n]);
			}
		}
		for (int num6 = 0; num6 < m_popupRemoves.Count; num6++)
		{
			m_popups.Remove(m_popupRemoves[num6]);
		}
		m_popupRemoves.Clear();
		m_distTravelledPerSec.Add(Position);
		if (m_distTravelledPerSec.Count > 180)
		{
			m_distTravelledPerSec.RemoveAt(0);
		}
		if (m_distTravelledPerSec.Count == 180)
		{
			if (!m_bCanDive && !m_bCanLeap && m_iDiveTimer <= 0 && m_iLeapTimer <= 0)
			{
				Vector2 val2 = m_distTravelledPerSec[120] - m_distTravelledPerSec[179];
				if (val2.Length() < 10f)
				{
					goto IL_045b;
				}
			}
			if (m_bCanLeap || m_bCanDive)
			{
				Vector2 val3 = m_distTravelledPerSec[0] - m_distTravelledPerSec[59];
				if (val3.Length() < 10f)
				{
					Vector2 val4 = m_distTravelledPerSec[60] - m_distTravelledPerSec[119];
					if (val4.Length() < 10f)
					{
						Vector2 val5 = m_distTravelledPerSec[120] - m_distTravelledPerSec[179];
						if (val5.Length() < 10f)
						{
							goto IL_045b;
						}
					}
				}
			}
		}
		m_bBabyStopped = false;
		goto IL_046b;
		IL_045b:
		m_bBabyStopped = true;
		goto IL_046b;
		IL_046b:
		for (int num7 = 0; num7 < m_propDecorSprite.Count; num7++)
		{
			m_propDecor[num7].Origin = m_sprites[m_propDecorSprite[num7]].Origin;
			m_propDecor[num7].Position = m_sprites[m_propDecorSprite[num7]].Position;
			m_propDecor[num7].Rotation = m_sprites[m_propDecorSprite[num7]].Rotation;
		}
		//AvatarHandler avatar = Game1.GetAvatar();
		//if (avatar != null)
		//{
		//	Vector2 position = SceneRenderer.GetCameraPosition() - m_sprites[0].Position;
		//	avatar.SetRotations(m_sprites[1].Rotation - m_sprites[0].Rotation, m_sprites[3].Rotation - m_sprites[0].Rotation, m_sprites[2].Rotation - m_sprites[0].Rotation, m_sprites[0].Rotation, position, 1001f);
		//	avatar.ShouldDraw = m_bBabyLaunched;
		//}
		if (m_iLeapTimer > 0)
		{
			m_iLeapTimer -= gameTime.ElapsedMilli;
			if (m_iLeapTimer > 0 && m_objs[0].Position.Y > -50f)
			{
				float num8 = 1300f;
				m_iParticleTimer += gameTime.ElapsedMilli;
				if (m_iParticleTimer > 60)
				{
					m_iParticleTimer -= 60;
					PhysicsOutfit physicsOutfit = m_physicsOutfit;
					Color blue = Color.Blue;
					Vector3 val6 = blue.ToVector3();
					Color white = Color.White;
					physicsOutfit.GenerateParticles(new Color((val6 + white.ToVector3()) / 2f));
				}
				if (m_objs[0].Velocity.Y > -1000f)
				{
					Vector2 val7 = default(Vector2);
					for (int num9 = 0; num9 < m_objs.Count; num9++)
					{
						float num10 = Math.Max((num - Math.Max(0f, val.X)) / num, 0f) * num2;
                        val7 = new Vector2(1f, -0.8f);
                        val7.Normalize();
						val7.X *= num10;
						if (val.Y > 0f)
						{
							m_objs[num9].Velocity = new Vector2(m_objs[num9].Velocity.X, 0f);
						}
						PhysicalRepresentation physicalRepresentation2 = m_objs[num9];
						physicalRepresentation2.Velocity += gameTime.FractionOfSecond * val7 * num8;
					}
				}
			}
		}
		if (m_iDiveTimer > 0)
		{
			m_iDiveTimer -= gameTime.ElapsedMilli;
			if (m_iDiveTimer > 0)
			{
				float num11 = 1500f;
				if (m_objs[0].Position.Y < 600f)
				{
					m_iParticleTimer += gameTime.ElapsedMilli;
					if (m_iParticleTimer > 60)
					{
						m_iParticleTimer -= 60;
						PhysicsOutfit physicsOutfit2 = m_physicsOutfit;
						Color lime = Color.Lime;
						Vector3 val8 = lime.ToVector3();
						Color white2 = Color.White;
						physicsOutfit2.GenerateParticles(new Color((val8 + white2.ToVector3()) / 2f));
					}
					if (m_objs[0].Velocity.Y < 1000f)
					{
						m_vVelMod += gameTime.FractionOfSecond * new Vector2(0f, 1f) * num11;
						for (int num12 = 0; num12 < m_objs.Count; num12++)
						{
							PhysicalRepresentation physicalRepresentation3 = m_objs[num12];
							physicalRepresentation3.Velocity += gameTime.FractionOfSecond * new Vector2(0f, 1f) * num11;
						}
					}
				}
			}
		}
		if (m_iLastDistance != DistanceTravelled)
		{
			int num13 = DistanceTravelled;
			int num14 = 0;
			if (num13 == 0)
			{
				m_distanceCharArray[num14] = '0';
				num14++;
			}
			else
			{
				while (num13 >= 1)
				{
					int num15 = num13 % 10;
					m_distanceCharArray[num14] = (char)(48 + num15);
					num13 /= 10;
					num14++;
				}
			}
			for (int num16 = 0; num16 < num14 / 2; num16++)
			{
				char c = m_distanceCharArray[num16];
				m_distanceCharArray[num16] = m_distanceCharArray[num14 - 1 - num16];
				m_distanceCharArray[num14 - 1 - num16] = c;
			}
			m_distanceCharArray[num14] = '\0';
			m_MutatedDistanceString.Length = 0;
			m_MutatedDistanceString.Insert(0, m_distanceCharArray, 0, num14);
			m_MutatedDistanceString.Length = num14;
			m_iLastDistance = DistanceTravelled;
			if (m_iLastDistance != 1)
			{
				m_MutatedDistanceString.Append(m_DistanceString);
			}
			else
			{
				m_MutatedDistanceString.Append(" foot");
			}
		}
		if (m_iLastScore == GetScore())
		{
			return;
		}
		int num17 = GetScore();
		int num18 = 0;
		if (num17 == 0)
		{
			m_scoreCharArray[num18] = '0';
			num18++;
		}
		else
		{
			while (num17 >= 1)
			{
				int num19 = num17 % 10;
				m_scoreCharArray[num18] = (char)(48 + num19);
				num17 /= 10;
				num18++;
			}
		}
		for (int num20 = 0; num20 < num18 / 2; num20++)
		{
			char c2 = m_scoreCharArray[num20];
			m_scoreCharArray[num20] = m_scoreCharArray[num18 - 1 - num20];
			m_scoreCharArray[num18 - 1 - num20] = c2;
		}
		m_scoreCharArray[num18] = '\0';
		m_MutatedScoreString.Length = 0;
		m_MutatedScoreString.Insert(0, m_scoreCharArray, 0, num18);
		m_MutatedScoreString.Length = num18;
		m_iLastScore = GetScore();
		if (m_iLastScore != 1)
		{
			m_MutatedScoreString.Append(m_ScoreString);
		}
		else
		{
			m_MutatedScoreString.Append(" point");
		}
	}

	public bool IsStopped()
	{
		return m_bBabyStopped;
	}

	public int GetScore()
	{
		return DistanceTravelled + m_iCollisionPoints;
	}

	public void Draw(TimeTracker gameTime)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		if (!m_bAvatar)
		{
			m_physicsOutfit.Draw(gameTime);
			for (int i = 0; i < m_propDecorSprite.Count; i++)
			{
				if (m_propDecorEnabled[i])
				{
					m_propDecor[i].Draw(gameTime);
				}
			}
		}
		for (int j = 0; j < m_popups.Count; j++)
		{
			m_popups[j].Draw(gameTime);
		}
		m_boostSpr.Position = SceneRenderer.GetCameraPosition() - new Vector2(-300f, 250f);
		m_flare1.Position = m_boostSpr.Position;
		m_diveSpr.Position = SceneRenderer.GetCameraPosition() - new Vector2(-300f, 200f);
		m_flare2.Position = m_diveSpr.Position;
		if (m_bCanDive)
		{
			m_diveSpr.Alpha += gameTime.FractionOfSecond * 6f;
		}
		else
		{
			m_diveSpr.Alpha -= gameTime.FractionOfSecond * 6f;
		}
		if (m_diveSpr.Alpha < 0f)
		{
			m_diveSpr.Alpha = 0f;
		}
		else if (m_diveSpr.Alpha > 1f)
		{
			m_diveSpr.Alpha = 1f;
		}
		if (m_diveSpr.Alpha == 1f || !m_bCanDive)
		{
			m_flare2.Alpha -= gameTime.FractionOfSecond * 6f;
			if (m_flare2.Alpha < 0f)
			{
				m_flare2.Alpha = 0f;
			}
		}
		else if (m_bCanDive)
		{
			m_flare2.Alpha = m_diveSpr.Alpha;
		}
		if (m_bCanLeap)
		{
			m_boostSpr.Alpha += gameTime.FractionOfSecond * 6f;
		}
		else
		{
			m_boostSpr.Alpha -= gameTime.FractionOfSecond * 6f;
		}
		if (m_boostSpr.Alpha < 0f)
		{
			m_boostSpr.Alpha = 0f;
		}
		else if (m_boostSpr.Alpha > 1f)
		{
			m_boostSpr.Alpha = 1f;
		}
		if (m_boostSpr.Alpha == 1f || !m_bCanLeap)
		{
			m_flare1.Alpha -= gameTime.FractionOfSecond * 6f;
			if (m_flare1.Alpha < 0f)
			{
				m_flare1.Alpha = 0f;
			}
		}
		else if (m_bCanLeap)
		{
			m_flare1.Alpha = m_boostSpr.Alpha;
		}
		m_flare1.Draw(gameTime);
		m_flare2.Draw(gameTime);
		m_boostSpr.Draw(gameTime);
		m_diveSpr.Draw(gameTime);
		SceneRenderer.DrawString(fonts.GRUNGE_FONT, m_MutatedDistanceString, SceneRenderer.GetCameraPosition() + SceneRenderer.GetScreenDim() * 0.4f - new Vector2(200f, 60f), Color.Black, new Vector2(1f, 1f), DepthConsts.LOGO_DEPTH);
		SceneRenderer.DrawString(fonts.GRUNGE_FONT, m_MutatedScoreString, SceneRenderer.GetCameraPosition() + SceneRenderer.GetScreenDim() * 0.4f - new Vector2(200f, 30f), Color.Black, new Vector2(1f, 1f), DepthConsts.LOGO_DEPTH);
	}

	public void HandleInput(TimeTracker gametime)
	{
		if (ControlManager.PressedButton(ControlManager.ActiveMenuIndex, (Buttons)16384))
		{
			if (m_bCanLeap)
			{
				m_bCanLeap = false;
				m_iLeapTimer = 500;
				m_iDiveTimer = 0;
			}
		}
		else if (ControlManager.PressedButton(ControlManager.ActiveMenuIndex, (Buttons)4096) && m_bCanDive)
		{
			m_bCanDive = false;
			m_iDiveTimer = 1000;
			m_iLeapTimer = 0;
		}
	}

	public void SaveFrameData(PropType type)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		m_iDiveCharge = 5000;
		for (int i = 0; i < m_objs.Count; i++)
		{
			m_vSavedVel[i] = m_objs[i].Velocity;
		}
		m_bRevertData = true;
		for (int j = 0; j < m_popups.Count; j++)
		{
			m_popups[j].ForceExit();
		}
		m_popups.Add(new AwardPopup(type));
		if (m_typeCounts.ContainsKey((int)type))
		{
			m_typeCounts[(int)type]++;
		}
		else
		{
			m_typeCounts[(int)type] = 1;
		}
		ControlManager.SetVibration(ControlManager.ActiveMenuIndex, 0.3f);
		m_bCanDive = true;
		m_bCanLeap = true;
		if (m_iLeapTimer > 0)
		{
			m_iLeapTimer = 1;
		}
		if (m_iDiveTimer > 0)
		{
			m_iDiveTimer = 1;
		}
		m_iCollisionPoints += 30;
	}

	public int GetTypeCount(PropType type)
	{
		if (m_typeCounts.ContainsKey((int)type))
		{
			return m_typeCounts[(int)type];
		}
		return 0;
	}
}
