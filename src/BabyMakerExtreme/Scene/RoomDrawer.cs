using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Renderer;

namespace Scene;

internal class RoomDrawer
{
	private const int BG_WIDTH = 1280;

	private List<RenderSprite> m_bg;

	private List<RenderSprite> m_floor;

	private List<RenderSprite> m_roof;

	private Rectangle m_area;

	public RoomDrawer()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		m_bg = new List<RenderSprite>();
		m_bg.Add(SpriteManager.GetSprite("images/roomDraw/backDrop", new Vector2(-2000f), DepthConsts.BACKGROUND_DEPTH));
		m_bg.Add(SpriteManager.GetSprite("images/roomDraw/backDrop", new Vector2(-2000f), DepthConsts.BACKGROUND_DEPTH - 0.1f));
		m_floor = new List<RenderSprite>();
		m_floor.Add(SpriteManager.GetSprite("images/roomDraw/floor", new Vector2(-2000f), DepthConsts.FLOOR_DEPTH));
		m_floor.Add(SpriteManager.GetSprite("images/roomDraw/floor", new Vector2(-2000f), DepthConsts.FLOOR_DEPTH - 0.1f));
		m_roof = new List<RenderSprite>();
		m_roof.Add(SpriteManager.GetSprite("images/roomDraw/roof", new Vector2(-2000f), DepthConsts.FLOOR_DEPTH));
		m_roof.Add(SpriteManager.GetSprite("images/roomDraw/roof", new Vector2(-2000f), DepthConsts.FLOOR_DEPTH - 0.1f));
		m_area = default(Rectangle);
	}

	public void Draw(TimeTracker gameTime)
	{
		for (int i = 0; i < m_bg.Count; i++)
		{
			if (i == 0 || m_area.Width > 1280)
			{
				m_bg[i].Draw(gameTime);
				m_floor[i].Draw(gameTime);
				m_roof[i].Draw(gameTime);
			}
		}
	}

	public void Update(TimeTracker gameTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		Vector2 cameraPosition = SceneRenderer.GetCameraPosition();
		if (cameraPosition.X > m_bg[1].Position.X && (float)(m_area.X + m_area.Width) > m_bg[1].Position.X + 640f)
		{
			m_bg[0].Position = m_bg[1].Position;
			m_bg[1].Position = new Vector2(m_bg[1].Position.X + 1280f, m_bg[1].Position.Y);
			m_floor[0].Position = new Vector2(m_bg[0].Position.X, m_floor[0].Position.Y);
			m_floor[1].Position = new Vector2(m_bg[1].Position.X, m_floor[1].Position.Y);
			m_roof[0].Position = new Vector2(m_bg[0].Position.X, m_roof[0].Position.Y);
			m_roof[1].Position = new Vector2(m_bg[1].Position.X, m_roof[1].Position.Y);
		}
		else if (cameraPosition.X < m_bg[0].Position.X && (float)m_area.X + 640f + 1f < m_bg[0].Position.X)
		{
			m_bg[1].Position = m_bg[0].Position;
			m_bg[0].Position = new Vector2(m_bg[1].Position.X - 1280f, m_bg[1].Position.Y);
			m_floor[0].Position = new Vector2(m_bg[0].Position.X, m_floor[0].Position.Y);
			m_floor[1].Position = new Vector2(m_bg[1].Position.X, m_floor[1].Position.Y);
			m_roof[0].Position = new Vector2(m_bg[0].Position.X, m_roof[0].Position.Y);
			m_roof[1].Position = new Vector2(m_bg[1].Position.X, m_roof[1].Position.Y);
		}
	}

	public void SetType(RoomType type)
	{
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		Color color = default(Color);
		Color color2 = default(Color);
		switch (type)
		{
		case RoomType.BIRTHROOM:
			color = new Color((byte)205, (byte)150, (byte)96);
			color2 = new Color((byte)176, (byte)214, (byte)210);
			break;
		case RoomType.CAFETERIA:
			color = new Color((byte)180, (byte)162, (byte)126);
			color2 = new Color((byte)214, (byte)155, (byte)155);
			break;
		case RoomType.HALLWAY:
			color = new Color((byte)216, (byte)220, (byte)167);
			color2 = new Color((byte)135, (byte)220, (byte)151);
			break;
		case RoomType.WAITINGROOM:
			color = new Color((byte)93, (byte)174, (byte)145);
			color2 = new Color((byte)200, (byte)159, (byte)159);
			break;
		case RoomType.BEDSROOM:
			color = new Color((byte)162, (byte)196, (byte)195);
			color2 = new Color((byte)98, (byte)118, (byte)118);
			break;
		case RoomType.PHYSIO:
			color = new Color((byte)145, (byte)114, (byte)100);
			color2 = new Color((byte)233, (byte)76, (byte)0);
			break;
		case RoomType.LAB:
			color = new Color((byte)198, (byte)207, (byte)227);
			color2 = new Color((byte)92, (byte)92, (byte)70);
			break;
		case RoomType.SURGERYTHEATRE:
			color = new Color((byte)180, (byte)207, (byte)250);
			color2 = new Color((byte)250, (byte)237, (byte)130);
			break;
		case RoomType.DIAGNOSIS:
			color = new Color((byte)245, (byte)245, (byte)142);
			color2 = new Color((byte)128, (byte)128, (byte)70);
			break;
		case RoomType.MORTUARY:
            color = new Color((byte)198, (byte)156, (byte)199);
            color2 = new Color((byte)84, (byte)57, (byte)162);
			break;
		default:
			color = new Color(byte.MaxValue, byte.MaxValue, byte.MaxValue);
            color2 = new Color((byte)100, (byte)100, (byte)100);
			break;
		}
		for (int i = 0; i < m_bg.Count; i++)
		{
			m_bg[i].Color = color;
			m_floor[i].Color = color2;
		}
	}

	public void SetArea(Rectangle r)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		m_area = r;
		if (m_area.Width < 1280)
		{
			m_bg[0].GetSpriteImage().Width = m_area.Width + 1;
			m_bg[0].SurfaceScale = new Vector2((float)(m_area.Width + 1), m_bg[0].SurfaceScale.Y);
			m_floor[0].GetSpriteImage().Width = m_area.Width + 1;
			m_floor[0].SurfaceScale = new Vector2((float)(m_area.Width + 1), m_floor[0].SurfaceScale.Y);
			m_roof[0].GetSpriteImage().Width = m_area.Width + 1;
			m_roof[0].SurfaceScale = new Vector2((float)(m_area.Width + 1), m_roof[0].SurfaceScale.Y);
		}
		else
		{
			m_bg[0].GetSpriteImage().Width = m_bg[0].Texture.Width;
			m_bg[0].SurfaceScale = new Vector2((float)m_bg[0].Texture.Width, m_bg[0].SurfaceScale.Y);
			m_floor[0].GetSpriteImage().Width = m_floor[0].Texture.Width;
			m_floor[0].SurfaceScale = new Vector2((float)m_floor[0].Texture.Width, m_floor[0].SurfaceScale.Y);
			m_roof[0].GetSpriteImage().Width = m_roof[0].Texture.Width;
			m_roof[0].SurfaceScale = new Vector2((float)m_roof[0].Texture.Width, m_roof[0].SurfaceScale.Y);
		}
		m_bg[0].Position = new Vector2((float)r.X + (m_bg[0].SurfaceScale.X - 1f) / 2f, (float)r.Bottom - m_floor[0].SurfaceScale.Y - m_bg[0].SurfaceScale.Y / 2f);
		m_bg[1].Position = new Vector2((float)r.X + (m_bg[1].SurfaceScale.X - 1f) * 1.5f, (float)r.Bottom - m_floor[0].SurfaceScale.Y - m_bg[0].SurfaceScale.Y / 2f);
		m_floor[0].Position = new Vector2((float)r.X + (m_bg[0].SurfaceScale.X - 1f) / 2f, (float)r.Bottom - m_floor[0].SurfaceScale.Y / 2f);
		m_floor[1].Position = new Vector2((float)r.X + (m_bg[1].SurfaceScale.X - 1f) * 1.5f, (float)r.Bottom - m_floor[0].SurfaceScale.Y / 2f);
		m_roof[0].Position = new Vector2((float)r.X + (m_bg[0].SurfaceScale.X - 1f) / 2f, m_bg[0].Position.Y - m_bg[0].SurfaceScale.Y / 2f - m_roof[0].SurfaceScale.Y / 2f);
		m_roof[1].Position = new Vector2((float)r.X + (m_bg[1].SurfaceScale.X - 1f) * 1.5f, m_bg[0].Position.Y - m_bg[0].SurfaceScale.Y / 2f - m_roof[0].SurfaceScale.Y / 2f);
	}
}
