using BabyMaker;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Renderer;

namespace Screens;

internal class GenericErrScreen : Screen
{
	private RenderSprite m_bg;

	private RenderSprite m_bgbehind;

	private string text;

	private int index;

	public GenericErrScreen(int controllerIndex, string s)
		: base(updateParent: false, drawParent: false, inputParent: false)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		index = controllerIndex;
		text = s;
		m_bg = SpriteManager.GetSprite("images/pausebg", SceneRenderer.GetScreenDim() / 2f - new Vector2(0f, 100f), 100f);
		m_bg.WidthScale *= 1.3f;
		m_bgbehind = SpriteManager.GetSprite("images/whitesquare", SceneRenderer.GetScreenDim() / 2f, 0f);
		m_bgbehind.Color = Color.Black;
		m_bgbehind.SurfaceScale = new Vector2(1280f, 1280f);
		text += "\n\nPress A to Continue";
	}

	public override void Draw(TimeTracker gameTime)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		m_bgbehind.Position = SceneRenderer.GetCameraPosition();
		m_bgbehind.Draw(gameTime);
		m_bg.Position = SceneRenderer.GetCameraPosition();
		m_bg.Draw(gameTime);
		SceneRenderer.DrawString(fonts.BASE_FONT, text, m_bg.Position - new Vector2(m_bg.SurfaceScale.X / 2f - 50f, 70f), Color.Black, DepthConsts.TEXT_DEPTH);
	}

	public override void HandleInput(TimeTracker gameTime)
	{
		if (ControlManager.PressedActivate(index) || ControlManager.PressedStart(index))
		{
			Game1.PopScreen("");
		}
	}

	public override void Update(TimeTracker gameTime)
	{
	}
}
