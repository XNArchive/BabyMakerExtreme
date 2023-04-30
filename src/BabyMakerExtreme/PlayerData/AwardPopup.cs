using System;
using Microsoft.Xna.Framework;
using Renderer;
using Scene;

namespace PlayerData;

public class AwardPopup
{
	private const int QUIET_TIME = 1000;

	private const int ENTER_TIME = 200;

	private const int EXIT_TIME = 200;

	private RenderSprite m_spr;

	private int m_iTimer;

	private Vector2 m_vStartScale;

	private static int sm_iNumSpawned;

	public AwardPopup(PropType type)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		switch (type)
		{
		case PropType.CRAB_MEAL:
			m_spr = SpriteManager.GetSprite("images/trophies/gotCrabs", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.DOCTOR:
		case PropType.SURGEON:
			m_spr = SpriteManager.GetSprite("images/trophies/docBlock", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.LUNCHLADY:
			m_spr = SpriteManager.GetSprite("images/trophies/eatingOut", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.GURNEY:
			m_spr = SpriteManager.GetSprite("images/trophies/onBottom", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.CRUTCHES:
			m_spr = SpriteManager.GetSprite("images/trophies/tripod", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.RECEPTION_DESK:
			m_spr = SpriteManager.GetSprite("images/trophies/blonds", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.LAB_MICROSCOPE_TABLE:
			m_spr = SpriteManager.GetSprite("images/trophies/enlargement", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.BEDSIDE_TABLE_FLOWER:
			m_spr = SpriteManager.GetSprite("images/trophies/deflower", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.SURGERY_LIGHT:
			m_spr = SpriteManager.GetSprite("images/trophies/lightsout", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.BYPASS_MACHINE:
			m_spr = SpriteManager.GetSprite("images/trophies/pumpIt", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.LAB_PILL_TABLE:
			m_spr = SpriteManager.GetSprite("images/trophies/pill", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.SKELETON:
			m_spr = SpriteManager.GetSprite("images/trophies/ridebones", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.LIMB_TABLE:
			m_spr = SpriteManager.GetSprite("images/trophies/strapon", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.DEAD_BODY:
			m_spr = SpriteManager.GetSprite("images/trophies/stiffy", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.XRAY:
			m_spr = SpriteManager.GetSprite("images/trophies/seeinside", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		case PropType.WALL:
			m_spr = SpriteManager.GetSprite("images/trophies/brokenprotect", default(Vector2), 5000 + sm_iNumSpawned);
			break;
		}
		m_vStartScale = m_spr.SurfaceScale;
		sm_iNumSpawned++;
	}

	public void Update(TimeTracker gameTime)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		m_iTimer += gameTime.ElapsedMilli;
		if (m_iTimer < 200)
		{
			m_spr.SurfaceScale = m_vStartScale * (float)Math.Sin(2f * ((float)m_iTimer / 200f));
		}
		else if (m_iTimer < 1200)
		{
			m_spr.SurfaceScale = m_vStartScale;
		}
		else
		{
			m_spr.SurfaceScale = m_vStartScale * (float)Math.Cos(2f * ((float)(m_iTimer - 1200) / 200f));
		}
		m_spr.Position = SceneRenderer.GetCameraPosition() + new Vector2(0f, 200f) + new Vector2(SceneRenderer.GetRand(-5f, 5f), SceneRenderer.GetRand(-5f, 5f));
		m_spr.Rotation = SceneRenderer.GetRand(-0.05f, 0.05f);
	}

	public void Draw(TimeTracker gameTime)
	{
		m_spr.Draw(gameTime);
	}

	public void ForceExit()
	{
		if (m_iTimer < 1200)
		{
			m_iTimer = 1200;
		}
	}

	public bool IsActive()
	{
		return m_iTimer < 1400;
	}
}
