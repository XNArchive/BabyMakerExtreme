using System;
using System.Collections.Generic;
using BabyMaker;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MusicPlayer;
using PlayerData;
using Renderer;
using Scene;

namespace Screens;

public class ScoreScreen : Screen
{
	private const int ENTER_TIME = 500;

	private const int PARTICLE_SPAWN = 400;

	public const float PIXELS_PER_FOOT = 75f;

	public const int NUM_TIPS = 9;

	private const float FADE_SPEED = 0.2f;

	private const int NUM_PER_PAGE = 4;

	private int m_iEnterTimer;

	private RenderSprite m_spr;

	private Vector2 m_vStartScale;

	private int m_iParticleSpawnTime;

	private List<string> m_text;

	private List<RenderSprite> m_awards;

	private List<string> m_typeCounts;

	private TransitionHelper m_trans;

	private bool m_bReset;

	private int m_iPage;

	private RenderSprite m_NextPageButton;

	private RenderSprite m_ShareButton;

	private RenderSprite m_RestartButton;

	private RenderSprite m_HighScoreButton;

	private RenderSprite m_dysfunc;

	private string m_shareString;

	private string m_restartString;

	private string m_nextPageString;

	private string m_highScoreString;

	private string m_finalScoreString;

	private string m_sex;

	private int m_iScore;

	private int m_iDist;

	private static int m_iNumRuns;

	private RenderSprite m_sprTips;

	private string m_tip;

	private bool m_bHighScores;

	private List<string> m_scoreNames;

	private List<string> m_scoreNums;

	public ScoreScreen(Player player)
		: base(updateParent: true, drawParent: true, inputParent: false)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		PlayBabySound();
		m_iParticleSpawnTime = 0;
		m_iEnterTimer = 0;
		m_sex = player.GetSex();
		if (/*player.Avatar*/ false)
		{
			//if (Game1.GetAvatar().IsMale())
			//{
			//	m_sex = "boy";
			//}
			//else
			//{
			//	m_sex = "girl";
			//}
		}
		m_iPage = 0;
		if (m_sex.Equals("boy"))
		{
			m_spr = SpriteManager.GetSprite("images/boyScore", default(Vector2), DepthConsts.SCORE_DEPTH);
			m_sprTips = SpriteManager.GetSprite("images/boyTips", default(Vector2), DepthConsts.SCORE_DEPTH + 0.1f);
		}
		else
		{
			m_spr = SpriteManager.GetSprite("images/girlScore", default(Vector2), DepthConsts.SCORE_DEPTH);
			m_sprTips = SpriteManager.GetSprite("images/girlTips", default(Vector2), DepthConsts.SCORE_DEPTH + 0.1f);
		}
		m_sprTips.SurfaceScale = new Vector2(m_sprTips.SurfaceScale.X, m_sprTips.SurfaceScale.Y * 0.8f);
		m_text = new List<string>();
		float rand = SceneRenderer.GetRand(0f, 1f);
		m_iNumRuns++;
		m_iDist = player.DistanceTravelled;
		string item = m_iDist + " feet";
		if (m_iDist == 1)
		{
			item = m_iDist + " foot";
		}
		if (rand < 0.5f || m_iNumRuns == 1)
		{
			m_text.Add("Your bouncing baby " + m_sex + " flew");
			m_text.Add(item);
			m_text.Add("before tumbling down.");
		}
		else if (rand < 0.65f)
		{
			m_text.Add("Your baby " + m_sex + " followed the");
			m_text.Add("cow and spoon over the moon and flew");
			m_text.Add(item);
		}
		else if (rand < 0.83f)
		{
			m_text.Add("Your baby " + m_sex + "'s daring escape");
			m_text.Add("made it to ");
			m_text.Add(item);
			if (m_sex.Equals("boy"))
			{
				m_text.Add("until gravity caught up with him.");
			}
			else
			{
				m_text.Add("until gravity caught up with her.");
			}
		}
		else
		{
			m_text.Add("Your baby " + m_sex + " started");
			if (m_sex.Equals("boy"))
			{
				m_text.Add("his extreme sports career flying");
			}
			else
			{
				m_text.Add("her extreme sports career flying");
			}
			m_text.Add("out of the womb for");
			m_text.Add(item);
		}
		m_vStartScale = m_spr.SurfaceScale;
		m_awards = new List<RenderSprite>();
		m_typeCounts = new List<string>();
		int num = 0;
		if (player.GetTypeCount(PropType.RECEPTION_DESK) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/blonds", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.RECEPTION_DESK));
			num += player.GetTypeCount(PropType.RECEPTION_DESK);
		}
		if (player.GetTypeCount(PropType.DOCTOR) + player.GetTypeCount(PropType.SURGEON) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/docBlock", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + (player.GetTypeCount(PropType.DOCTOR) + player.GetTypeCount(PropType.SURGEON)));
			num += player.GetTypeCount(PropType.DOCTOR) + player.GetTypeCount(PropType.SURGEON);
		}
		if (player.GetTypeCount(PropType.LUNCHLADY) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/eatingOut", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.LUNCHLADY));
			num += player.GetTypeCount(PropType.LUNCHLADY);
		}
		if (player.GetTypeCount(PropType.CRAB_MEAL) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/gotCrabs", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.CRAB_MEAL));
			num += player.GetTypeCount(PropType.CRAB_MEAL);
		}
		if (player.GetTypeCount(PropType.GURNEY) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/onBottom", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.GURNEY));
			num += player.GetTypeCount(PropType.GURNEY);
		}
		if (player.GetTypeCount(PropType.CRUTCHES) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/tripod", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.CRUTCHES));
			num += player.GetTypeCount(PropType.CRUTCHES);
		}
		if (player.GetTypeCount(PropType.LAB_MICROSCOPE_TABLE) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/enlargement", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.LAB_MICROSCOPE_TABLE));
			num += player.GetTypeCount(PropType.LAB_MICROSCOPE_TABLE);
		}
		if (player.GetTypeCount(PropType.BEDSIDE_TABLE_FLOWER) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/deflower", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.BEDSIDE_TABLE_FLOWER));
			num += player.GetTypeCount(PropType.BEDSIDE_TABLE_FLOWER);
		}
		if (player.GetTypeCount(PropType.SURGERY_LIGHT) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/lightsout", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.SURGERY_LIGHT));
			num += player.GetTypeCount(PropType.SURGERY_LIGHT);
		}
		if (player.GetTypeCount(PropType.BYPASS_MACHINE) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/pumpIt", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.BYPASS_MACHINE));
			num += player.GetTypeCount(PropType.BYPASS_MACHINE);
		}
		if (player.GetTypeCount(PropType.LAB_PILL_TABLE) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/pill", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.LAB_PILL_TABLE));
			num += player.GetTypeCount(PropType.LAB_PILL_TABLE);
		}
		if (player.GetTypeCount(PropType.SKELETON) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/ridebones", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.SKELETON));
			num += player.GetTypeCount(PropType.SKELETON);
		}
		if (player.GetTypeCount(PropType.LIMB_TABLE) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/strapon", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.LIMB_TABLE));
			num += player.GetTypeCount(PropType.LIMB_TABLE);
		}
		if (player.GetTypeCount(PropType.DEAD_BODY) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/stiffy", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.DEAD_BODY));
			num += player.GetTypeCount(PropType.DEAD_BODY);
		}
		if (player.GetTypeCount(PropType.XRAY) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/seeinside", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.XRAY));
			num += player.GetTypeCount(PropType.XRAY);
		}
		if (player.GetTypeCount(PropType.WALL) > 0)
		{
			m_awards.Add(SpriteManager.GetSprite("images/trophies/brokenprotect", default(Vector2), m_spr.Depth + 1f));
			m_typeCounts.Add("x" + player.GetTypeCount(PropType.WALL));
			num += player.GetTypeCount(PropType.WALL);
		}
		for (int i = 0; i < m_awards.Count; i++)
		{
			m_awards[i].WidthScale /= 2f;
		}
		m_trans = new TransitionHelper();
		m_bReset = false;
		m_NextPageButton = SpriteManager.GetSprite("images/controllerbuttons/A", m_spr.Position + new Vector2(30f, 150f), DepthConsts.SCORE_DEPTH + 0.01f);
		m_RestartButton = SpriteManager.GetSprite("images/controllerbuttons/Y", m_spr.Position + new Vector2(30f, 190f), DepthConsts.SCORE_DEPTH + 0.02f);
		m_ShareButton = SpriteManager.GetSprite("images/controllerbuttons/B", m_spr.Position + new Vector2(30f, 230f), DepthConsts.SCORE_DEPTH + 0.03f);
		m_HighScoreButton = SpriteManager.GetSprite("images/controllerbuttons/X", m_spr.Position + new Vector2(30f, 270f), DepthConsts.SCORE_DEPTH + 0.04f);
		m_shareString = "Share";
		m_restartString = "Restart";
		m_nextPageString = "Next Page";
		m_highScoreString = "High Scores";
		m_iScore = player.GetScore();
		m_finalScoreString = "Final Score\n" + m_iScore;
		m_tip = "Tip!!! " + GenerateTip(player, 0);
		m_bHighScores = false;
		Game1.AddHighScore(Game1.GetPlayerName(ControlManager.ActiveMenuIndex), m_iScore);
		m_scoreNums = new List<string>();
		m_scoreNames = Game1.GetHighScoreNames();
		List<int> highScores = Game1.GetHighScores();
		for (int j = 0; j < highScores.Count; j++)
		{
			m_scoreNums.Add(string.Concat(highScores[j]));
		}
		if (num == 0)
		{
			m_dysfunc = SpriteManager.GetSprite("images/trophies/projectileDysfunc", default(Vector2), m_spr.Depth + 1f);
			m_dysfunc.WidthScale *= 0.8f;
			m_dysfunc.Alpha = 0f;
		}
	}

	public static string GenerateTip(Player p, int tipNum)
	{
		if (p != null)
		{
			tipNum = (p.BadBreathing ? 1 : ((!p.BadPushing) ? ((int)SceneRenderer.GetRand(0f, 9f)) : 0));
		}
		return tipNum switch
		{
			0 => "When pushing mash the B\nbutton as fast as possible\nto get a stronger launch.", 
			1 => "Controlling your breathing by\nmatching the triggers gives\nyou more time to push.", 
			2 => "Aim for glowing targets with\nyour dives to get a boost\nback into the air", 
			3 => "If you use dives to reach\nglowing targets your bounce\nback can be higher.", 
			4 => "Hitting non-glowing objects\n can slow you down or stop you\ncompletely.", 
			5 => "Try to avoid hitting ceilings\n as they will also slow you down.", 
			6 => "Boost gives you a small\nhorizontal and vertical boost.", 
			7 => "Glowing objects give you a\nsmall horizontal boost in\nspeed.", 
			8 => "Learn the room colors and\ntheir targets to better\npredict dangers.", 
			_ => "", 
		};
	}

	public override void Draw(TimeTracker gameTime)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		m_spr.Position = SceneRenderer.GetCameraPosition() - new Vector2(0f, 60f);
		m_spr.Draw(gameTime);
		float num = m_spr.SurfaceScale.X / m_vStartScale.X;
		m_sprTips.WidthScale = num * (float)m_spr.Texture.Width;
		m_sprTips.Position = SceneRenderer.GetCameraPosition() + new Vector2(0f, 260f);
		m_sprTips.Draw(gameTime);
		SceneRenderer.DrawString(fonts.GRUNGE_FONT, m_tip, m_sprTips.Position + num * new Vector2(-200f, -50f), Color.Black, m_sprTips.Depth + 1f);
		if (m_bHighScores)
		{
			Color black = Color.Black;
			if (m_awards.Count > 0)
			{
                black.A = (byte)(255f * (1f - m_awards[m_iPage * 4].Alpha));
			}
			else
			{
                black.A = (byte)(255f * (1f - m_dysfunc.Alpha));
			}
			SceneRenderer.DrawString(fonts.BUTTON_FONT, m_highScoreString, m_spr.Position + num * new Vector2((0f - SceneRenderer.GetStringWidth(fonts.BUTTON_FONT, m_highScoreString)) / 2f, -260f), black, new Vector2(num), m_spr.Depth + 1f);
			for (int i = 0; i < m_scoreNames.Count; i++)
			{
				SceneRenderer.DrawString(fonts.BASE_FONT, m_scoreNames[i], m_spr.Position + num * new Vector2(-200f, (float)(-200 + i * 20)), black, new Vector2(num * 0.7f), m_spr.Depth + 1f);
				SceneRenderer.DrawString(fonts.BASE_FONT, m_scoreNums[i], m_spr.Position + num * new Vector2(100f, (float)(-200 + i * 20)), black, new Vector2(num * 0.7f), m_spr.Depth + 1f);
			}
		}
		else
		{
			for (int j = 0; j < m_text.Count; j++)
			{
				SceneRenderer.DrawString(fonts.GRUNGE_FONT, m_text[j], m_spr.Position - num * new Vector2(SceneRenderer.GetStringWidth(fonts.GRUNGE_FONT, m_text[j]) / 2f, (float)(250 - j * 30)), Color.Black, new Vector2(num), m_spr.Depth + 1f);
			}
			for (int k = 0; k < m_awards.Count; k++)
			{
				m_awards[k].Position = m_spr.Position - num * new Vector2((float)(130 - k % 4 / 2 * 200), (float)(70 - k % 4 % 2 * 130));
				m_awards[k].Draw(gameTime);
				Color black2 = Color.Black;
                black2.A = (byte)(255f * m_awards[k].Alpha);
				SceneRenderer.DrawString(fonts.GRUNGE_FONT, m_typeCounts[k], m_spr.Position - num * new Vector2((float)(70 - k % 4 / 2 * 200), (float)(100 - k % 4 % 2 * 130)), black2, new Vector2(num), m_spr.Depth + 1f);
			}
			if (m_awards.Count == 0)
			{
				m_dysfunc.Position = m_spr.Position;
				m_dysfunc.Draw(gameTime);
			}
			m_HighScoreButton.Position = m_spr.Position + num * new Vector2(-210f, 230f);
			m_ShareButton.Position = m_spr.Position + num * new Vector2(30f, 230f);
			m_RestartButton.Position = m_spr.Position + num * new Vector2(30f, 190f);
			m_NextPageButton.Position = m_spr.Position + num * new Vector2(30f, 150f);
			m_HighScoreButton.Draw(gameTime);
			m_ShareButton.Draw(gameTime);
			m_RestartButton.Draw(gameTime);
			if ((m_awards.Count - 1) / 4 > 0)
			{
				m_NextPageButton.Draw(gameTime);
				SceneRenderer.DrawString(fonts.GRUNGE_FONT, m_nextPageString, m_NextPageButton.Position + num * new Vector2(40f, -20f), Color.Black, new Vector2(num), m_ShareButton.Depth);
			}
			SceneRenderer.DrawString(fonts.GRUNGE_FONT, m_highScoreString, m_HighScoreButton.Position + num * new Vector2(40f, -20f), Color.Black, new Vector2(num), m_ShareButton.Depth);
			SceneRenderer.DrawString(fonts.GRUNGE_FONT, m_shareString, m_ShareButton.Position + num * new Vector2(40f, -20f), Color.Black, new Vector2(num), m_ShareButton.Depth);
			SceneRenderer.DrawString(fonts.GRUNGE_FONT, m_restartString, m_RestartButton.Position + num * new Vector2(40f, -20f), Color.Black, new Vector2(num), m_ShareButton.Depth);
			SceneRenderer.DrawString(fonts.GRUNGE_FONT, m_finalScoreString, m_spr.Position + num * new Vector2(-200f, 130f), Color.Black, new Vector2(num), m_ShareButton.Depth);
		}
		m_trans.Draw(gameTime);
	}

	public override void HandleInput(TimeTracker gameTime)
	{
		if (m_bReset || m_iEnterTimer < 500)
		{
			return;
		}
		if (m_bHighScores)
		{
			if (ControlManager.PressedButton(ControlManager.ActiveMenuIndex, (Buttons)16384) || ControlManager.PressedActivate(ControlManager.ActiveMenuIndex) || ControlManager.PressedButton(ControlManager.ActiveMenuIndex, (Buttons)8192) || ControlManager.PressedButton(ControlManager.ActiveMenuIndex, (Buttons)32768))
			{
				m_bHighScores = !m_bHighScores;
			}
			return;
		}
		if (ControlManager.PressedActivate(ControlManager.ActiveMenuIndex))
		{
			SwapAwards();
		}
		if (ControlManager.PressedButton(ControlManager.ActiveMenuIndex, (Buttons)32768) && !m_bReset)
		{
			m_trans.TransitionIn();
			Mp3MusicPlayer.FadeOut(0.1f);
			m_bReset = true;
		}
		if (ControlManager.PressedButton(ControlManager.ActiveMenuIndex, (Buttons)8192))
		{
			Game1.SendMessageToFriend(GenerateScoreMessage());
		}
		if (ControlManager.PressedButton(ControlManager.ActiveMenuIndex, (Buttons)16384))
		{
			m_bHighScores = !m_bHighScores;
		}
	}

	public string GenerateScoreMessage()
	{
		return "I just launched my bouncing baby " + m_sex + " " + m_iDist + " feet and earned a score of " + m_iScore + " in Baby Maker Extreme!";
	}

	public void SwapAwards()
	{
		m_iPage++;
		if (m_iPage > (m_awards.Count - 1) / 4)
		{
			m_iPage = 0;
		}
	}

	public override void Update(TimeTracker gameTime)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		m_iEnterTimer += gameTime.ElapsedMilli;
		m_trans.Update(gameTime);
		if (m_iEnterTimer > 500)
		{
			m_iEnterTimer = 500;
		}
		m_spr.SurfaceScale = m_vStartScale * (float)(Math.Sin(1.65f * ((float)m_iEnterTimer / 400f)) / Math.Sin(2.0624999701976776));
		m_iParticleSpawnTime += gameTime.ElapsedMilli;
		while (m_iParticleSpawnTime > 400)
		{
			m_iParticleSpawnTime -= 400;
			ParticleManager.GetParticle().Initialize(GenericParticleImgs.GetParticle(), SceneRenderer.GetCameraPosition() + new Vector2(SceneRenderer.GetRand(-350f, 350f), SceneRenderer.GetRand(-320f, -260f)), SceneRenderer.GetRand(-2f, -1f), (int)SceneRenderer.GetRand(700f, 2000f), new Vector2(0f, 0f), fadesOut: true, Color.Black, Color.Black, 20f, 200f, additive: false, new Vector2(0f, 0f), SceneRenderer.GetRand(0f, 3.14f), 0f, default(Vector2));
			ParticleManager.GetParticle().Initialize(GenericParticleImgs.GetParticle(), SceneRenderer.GetCameraPosition() + new Vector2(SceneRenderer.GetRand(-350f, 350f), SceneRenderer.GetRand(260f, 320f)), SceneRenderer.GetRand(-2f, -1f), (int)SceneRenderer.GetRand(700f, 2000f), new Vector2(0f, 0f), fadesOut: true, Color.Black, Color.Black, 20f, 200f, additive: false, new Vector2(0f, 0f), SceneRenderer.GetRand(0f, 3.14f), 0f, default(Vector2));
			ParticleManager.GetParticle().Initialize(GenericParticleImgs.GetParticle(), SceneRenderer.GetCameraPosition() + new Vector2(SceneRenderer.GetRand(-320f, -260f), SceneRenderer.GetRand(-350f, 350f)), SceneRenderer.GetRand(-2f, -1f), (int)SceneRenderer.GetRand(700f, 2000f), new Vector2(0f, 0f), fadesOut: true, Color.Black, Color.Black, 20f, 200f, additive: false, new Vector2(0f, 0f), SceneRenderer.GetRand(0f, 3.14f), 0f, default(Vector2));
			ParticleManager.GetParticle().Initialize(GenericParticleImgs.GetParticle(), SceneRenderer.GetCameraPosition() + new Vector2(SceneRenderer.GetRand(260f, 320f), SceneRenderer.GetRand(-350f, 350f)), SceneRenderer.GetRand(-2f, -1f), (int)SceneRenderer.GetRand(700f, 2000f), new Vector2(0f, 0f), fadesOut: true, Color.Black, Color.Black, 20f, 200f, additive: false, new Vector2(0f, 0f), SceneRenderer.GetRand(0f, 3.14f), 0f, default(Vector2));
		}
		if (m_trans.IsTransitionedIn)
		{
			Game1.PopScreen("Restart");
			Game1.SaveGlobalOptions();
		}
		for (int i = 0; i < m_awards.Count; i++)
		{
			if (m_iPage != i / 4 || m_bHighScores)
			{
				m_awards[i].Alpha -= gameTime.FractionOfSecond / 0.2f;
			}
			else
			{
				m_awards[i].Alpha += gameTime.FractionOfSecond / 0.2f;
			}
			if (m_awards[i].Alpha > 1f)
			{
				m_awards[i].Alpha = 1f;
			}
			else if (m_awards[i].Alpha < 0f)
			{
				m_awards[i].Alpha = 0f;
			}
		}
		if (m_awards.Count == 0)
		{
			if (m_bHighScores)
			{
				m_dysfunc.Alpha -= gameTime.FractionOfSecond / 0.2f;
			}
			else
			{
				m_dysfunc.Alpha += gameTime.FractionOfSecond / 0.2f;
			}
			if (m_dysfunc.Alpha > 1f)
			{
				m_dysfunc.Alpha = 1f;
			}
			else if (m_dysfunc.Alpha < 0f)
			{
				m_dysfunc.Alpha = 0f;
			}
		}
	}

	public void PlayBabySound()
	{
		int num = (int)SceneRenderer.GetRand(0f, 11f);
		string text = "";
		switch (num)
		{
		case 0:
			text = "14264__pfly__babybabblebit01";
			break;
		case 1:
			text = "18275__Corsica_S__baby_giggle";
			break;
		case 2:
			text = "47370__reinsamba__baby_laugh1";
			break;
		case 3:
			text = "47371__reinsamba__baby_laugh2";
			break;
		case 4:
			text = "47372__reinsamba__baby_laugh3";
			break;
		case 5:
			text = "47374__reinsamba__baby_voice15";
			break;
		case 6:
			text = "47375__reinsamba__baby_voice16";
			break;
		case 7:
			text = "59459__Erdie__Lena_laughes03";
			break;
		case 8:
			text = "59460__Erdie__Lena_laughes09";
			break;
		case 9:
			text = "65895__Robinhood76";
			break;
		case 10:
			text = "81211__bennstir__Baby_laugh1";
			break;
		}
		SoundManager.AddSoundToPlay(SoundManager.GetSoundEffect("sounds/freesound/babies/" + text), 1f, 0f, 0);
	}
}
