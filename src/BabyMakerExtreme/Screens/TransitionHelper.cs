using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Renderer;

namespace Screens;

public class TransitionHelper
{
	private int m_iTransitionTimer;

	private RenderSprite m_FadeSprite;

	private int m_iTotalTransitionTime;

	private bool m_bIsTransitioningFull;

	private bool m_bIsTransitioningOut;

	private bool m_bIsTransitioningIn;

	public int TransitionTime
	{
		get
		{
			return m_iTotalTransitionTime;
		}
		set
		{
			m_iTotalTransitionTime = value;
		}
	}

	public bool IsTransitionedIn => m_iTransitionTimer >= m_iTotalTransitionTime / 2;

	public bool IsTransitionedOut
	{
		get
		{
			if (!m_bIsTransitioningFull && !m_bIsTransitioningOut)
			{
				return !m_bIsTransitioningIn;
			}
			return false;
		}
	}

	public TransitionHelper()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		m_bIsTransitioningIn = false;
		m_bIsTransitioningOut = false;
		m_bIsTransitioningFull = false;
		m_iTransitionTimer = 0;
		m_iTotalTransitionTime = 1000;
		m_FadeSprite = SpriteManager.GetSprite("images/whitesquare", default(Vector2), DepthConsts.FADE_DEPTH);
		m_FadeSprite.Color = Color.Black;
	}

	public void Update(TimeTracker gameTime)
	{
		if (m_bIsTransitioningFull || m_bIsTransitioningOut)
		{
			m_iTransitionTimer += gameTime.ElapsedMilli;
			if (m_iTransitionTimer > m_iTotalTransitionTime)
			{
				m_iTransitionTimer = m_iTotalTransitionTime;
				m_bIsTransitioningFull = false;
				m_bIsTransitioningOut = false;
			}
		}
		if (m_bIsTransitioningIn)
		{
			m_iTransitionTimer += gameTime.ElapsedMilli;
			if (m_iTransitionTimer > m_iTotalTransitionTime / 2)
			{
				m_iTransitionTimer = m_iTotalTransitionTime / 2;
				m_bIsTransitioningIn = false;
			}
		}
		m_FadeSprite.Alpha = (float)Math.Sin(Math.PI * (double)(float)m_iTransitionTimer / (double)m_iTotalTransitionTime);
	}

	public void Draw(TimeTracker gameTime)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		m_FadeSprite.Position = SceneRenderer.GetCameraPosition();
		m_FadeSprite.SurfaceScale = SceneRenderer.GetViewportDim() * 2f;
		m_FadeSprite.Draw(gameTime);
	}

	public void StartTransition()
	{
		m_iTransitionTimer = 0;
		m_bIsTransitioningFull = true;
		m_bIsTransitioningIn = false;
		m_bIsTransitioningOut = false;
		m_FadeSprite.Alpha = (float)Math.Sin(Math.PI * (double)(float)m_iTransitionTimer / (double)m_iTotalTransitionTime);
	}

	public void TransitionIn()
	{
		m_iTransitionTimer = 0;
		m_bIsTransitioningIn = true;
		m_bIsTransitioningOut = false;
		m_bIsTransitioningFull = false;
		m_FadeSprite.Alpha = (float)Math.Sin(Math.PI * (double)(float)m_iTransitionTimer / (double)m_iTotalTransitionTime);
	}

	public void TransitionOut()
	{
		m_iTransitionTimer = m_iTotalTransitionTime / 2;
		m_bIsTransitioningIn = false;
		m_bIsTransitioningOut = true;
		m_bIsTransitioningFull = false;
		m_FadeSprite.Alpha = (float)Math.Sin(Math.PI * (double)(float)m_iTransitionTimer / (double)m_iTotalTransitionTime);
	}
}
