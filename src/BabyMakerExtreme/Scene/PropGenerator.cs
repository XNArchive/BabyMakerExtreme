using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Renderer;

namespace Scene;

public static class PropGenerator
{
	public static void CreateBaby(PhysicsOutfit outfit)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(164, 1495, 100, 106), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(9.6f, 0f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-42f, -26f));
		list.Last().Add(new Vector2(-34f, 1f));
		list.Last().Add(new Vector2(-21f, 23f));
		list.Last().Add(new Vector2(4f, 36f));
		list.Last().Add(new Vector2(17f, 32f));
		list.Last().Add(new Vector2(23f, 21f));
		list.Last().Add(new Vector2(19f, 12f));
		list.Last().Add(new Vector2(10f, 6f));
		list.Last().Add(new Vector2(3f, -7f));
		list.Last().Add(new Vector2(3f, -17f));
		list.Last().Add(new Vector2(-7f, -35f));
		list.Last().Add(new Vector2(-18f, -40f));
		list.Last().Add(new Vector2(-28f, -39f));
		list.Last().Add(new Vector2(-37f, -35f));
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(67, 1405, 82, 84), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(11.2f, 51.19999f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-36f, -65f));
		list.Last().Add(new Vector2(-37f, -46f));
		list.Last().Add(new Vector2(-30f, -36f));
		list.Last().Add(new Vector2(-25f, -35f));
		list.Last().Add(new Vector2(-17f, -25f));
		list.Last().Add(new Vector2(-7f, -21f));
		list.Last().Add(new Vector2(6f, -27f));
		list.Last().Add(new Vector2(8f, -33f));
		list.Last().Add(new Vector2(12f, -31f));
		list.Last().Add(new Vector2(11f, -41f));
		list.Last().Add(new Vector2(15f, -45f));
		list.Last().Add(new Vector2(18f, -56f));
		list.Last().Add(new Vector2(10f, -74f));
		list.Last().Add(new Vector2(-11f, -81f));
		list.Last().Add(new Vector2(-27f, -78f));
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(163, 1404, 83, 89), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-22.4f, -9.6f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(7f, 38f));
		list.Last().Add(new Vector2(0f, 31f));
		list.Last().Add(new Vector2(-5f, 15f));
		list.Last().Add(new Vector2(1f, -13f));
		list.Last().Add(new Vector2(10f, -17f));
		list.Last().Add(new Vector2(32f, 5f));
		list.Last().Add(new Vector2(50f, 6f));
		list.Last().Add(new Vector2(52f, 9f));
		list.Last().Add(new Vector2(30f, 16f));
		list.Last().Add(new Vector2(27f, 15f));
		list.Last().Add(new Vector2(21f, 6f));
		list.Last().Add(new Vector2(22f, 23f));
		list.Last().Add(new Vector2(22f, 32f));
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(55, 1499, 92, 76), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(8f, 8f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-41f, -20f));
		list.Last().Add(new Vector2(-32f, -13f));
		list.Last().Add(new Vector2(-19f, 12f));
		list.Last().Add(new Vector2(-13f, 14f));
		list.Last().Add(new Vector2(-1f, 9f));
		list.Last().Add(new Vector2(23f, -8f));
		list.Last().Add(new Vector2(25f, -16f));
		list.Last().Add(new Vector2(18f, -24f));
		list.Last().Add(new Vector2(12f, -20f));
		list.Last().Add(new Vector2(12f, -14f));
		list.Last().Add(new Vector2(-10f, 1f));
		list.Last().Add(new Vector2(-18f, -21f));
		list.Last().Add(new Vector2(-25f, -30f));
		list.Last().Add(new Vector2(-37f, -32f));
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(161, 1405, 83, 87), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(-16f, -3.2f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-9f, -18f));
		list.Last().Add(new Vector2(-8f, -2f));
		list.Last().Add(new Vector2(-1f, 19f));
		list.Last().Add(new Vector2(6f, 30f));
		list.Last().Add(new Vector2(24f, 19f));
		list.Last().Add(new Vector2(17f, 0f));
		list.Last().Add(new Vector2(22f, 3f));
		list.Last().Add(new Vector2(27f, 4f));
		list.Last().Add(new Vector2(47f, -9f));
		list.Last().Add(new Vector2(43f, -13f));
		list.Last().Add(new Vector2(26f, -8f));
		list.Last().Add(new Vector2(1f, -24f));
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(-18f, -32f));
		list5.Add(PhysicsJointType.ULTRAFIRM_JOINT);
		list3.Add(0);
		list3.Add(2);
		list4.Add(new Vector2(10f, 25f));
		list5.Add(PhysicsJointType.ULTRAFIRM_JOINT);
		list3.Add(0);
		list3.Add(3);
		list4.Add(new Vector2(-30f, -21f));
		list5.Add(PhysicsJointType.ULTRAFIRM_JOINT);
		list3.Add(0);
		list3.Add(4);
		list4.Add(new Vector2(11f, 18f));
		list5.Add(PhysicsJointType.ULTRAFIRM_JOINT);
		list6.Add(0);
		list6.Add(0);
		list6.Add(0);
		list6.Add(0);
		list6.Add(0);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateBirthMother(PhysicsOutfit outfit)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(0, 500, 344, 381), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 161.6f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(79f, -157f));
		list.Last().Add(new Vector2(-160f, -160f));
		list.Last().Add(new Vector2(-158f, -2f));
		list.Last().Add(new Vector2(44f, -1f));
		list.Last().Add(new Vector2(45f, -139f));
		list.Last().Add(new Vector2(80f, -139f));
		list3.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateDoctor(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(532, 605, 138, 214), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 94.39995f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-5f, -41f));
		list.Last().Add(new Vector2(-52f, -40f));
		list.Last().Add(new Vector2(-51f, -3f));
		list.Last().Add(new Vector2(44f, -3f));
		list.Last().Add(new Vector2(43f, -182f));
		list.Last().Add(new Vector2(-6f, -181f));
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(692, 378, 151, 269), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(-12.8f, 265.6004f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-23f, -380f));
		list.Last().Add(new Vector2(-46f, -153f));
		list.Last().Add(new Vector2(68f, -151f));
		list.Last().Add(new Vector2(54f, -382f));
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(700, 665, 108, 201), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(4.8f, 275.2005f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(5f, -361f));
		list.Last().Add(new Vector2(-31f, -240f));
		list.Last().Add(new Vector2(-23f, -237f));
		list.Last().Add(new Vector2(-40f, -218f));
		list.Last().Add(new Vector2(-33f, -192f));
		list.Last().Add(new Vector2(-2f, -196f));
		list.Last().Add(new Vector2(-3f, -226f));
		list.Last().Add(new Vector2(3f, -224f));
		list.Last().Add(new Vector2(27f, -344f));
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(719, 185, 109, 147), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(-8.000007f, 424.001f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-3f, -372f));
		list.Last().Add(new Vector2(-4f, -400f));
		list.Last().Add(new Vector2(-19f, -401f));
		list.Last().Add(new Vector2(-33f, -417f));
		list.Last().Add(new Vector2(-22f, -437f));
		list.Last().Add(new Vector2(-23f, -456f));
		list.Last().Add(new Vector2(-21f, -474f));
		list.Last().Add(new Vector2(36f, -476f));
		list.Last().Add(new Vector2(44f, -464f));
		list.Last().Add(new Vector2(42f, -448f));
		list.Last().Add(new Vector2(39f, -450f));
		list.Last().Add(new Vector2(36f, -408f));
		list.Last().Add(new Vector2(31f, -404f));
		list.Last().Add(new Vector2(34f, -374f));
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(532, 605, 138, 214), default(Vector2), -1.01f));
		list2.Last().Last().Origin = new Vector2(0f, 94.39995f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(692, 378, 151, 269), default(Vector2), -1.02f));
		list2.Last().Last().Origin = new Vector2(-12.8f, 265.6004f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(700, 665, 108, 201), default(Vector2), -1.03f));
		list2.Last().Last().Origin = new Vector2(4.8f, 275.2005f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(719, 185, 109, 147), default(Vector2), -1.01f));
		list2.Last().Last().Origin = new Vector2(-8.000007f, 424.001f);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(19f, -168f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(14f, -337f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(3);
		list4.Add(new Vector2(15f, -374f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list6.Add(0);
		list6.Add(0);
		list6.Add(0);
		list6.Add(0);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateDocStand(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1957, 1465, 152, 260), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(4.800001f, 111.9999f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-63f, -224f));
		list.Last().Add(new Vector2(-63f, -206f));
		list.Last().Add(new Vector2(-56f, -206f));
		list.Last().Add(new Vector2(-57f, -101f));
		list.Last().Add(new Vector2(-62f, -100f));
		list.Last().Add(new Vector2(-62f, -21f));
		list.Last().Add(new Vector2(-57f, -6f));
		list.Last().Add(new Vector2(-49f, 1f));
		list.Last().Add(new Vector2(-38f, 2f));
		list.Last().Add(new Vector2(-29f, -12f));
		list.Last().Add(new Vector2(-25f, -26f));
		list.Last().Add(new Vector2(15f, -25f));
		list.Last().Add(new Vector2(20f, -9f));
		list.Last().Add(new Vector2(31f, 3f));
		list.Last().Add(new Vector2(46f, 0f));
		list.Last().Add(new Vector2(51f, -14f));
		list.Last().Add(new Vector2(52f, -29f));
		list.Last().Add(new Vector2(50f, -101f));
		list.Last().Add(new Vector2(44f, -98f));
		list.Last().Add(new Vector2(43f, -207f));
		list.Last().Add(new Vector2(49f, -207f));
		list.Last().Add(new Vector2(50f, -225f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(464, 527, 110, 51), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(6.4f, 230.4003f);
		list4.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-48f, -242f));
		list.Last().Add(new Vector2(-40f, -229f));
		list.Last().Add(new Vector2(28f, -226f));
		list.Last().Add(new Vector2(26f, -239f));
		list3.Add(1);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateOldComputer(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(347, 1069, 182, 184), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 76.79996f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-74f, -155f));
		list.Last().Add(new Vector2(-75f, -125f));
		list.Last().Add(new Vector2(-64f, -123f));
		list.Last().Add(new Vector2(-64f, -5f));
		list.Last().Add(new Vector2(62f, -4f));
		list.Last().Add(new Vector2(63f, -123f));
		list.Last().Add(new Vector2(71f, -124f));
		list.Last().Add(new Vector2(72f, -154f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(356, 987, 155, 68), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(0f, 179.2001f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-59f, -199f));
		list.Last().Add(new Vector2(-59f, -163f));
		list.Last().Add(new Vector2(59f, -162f));
		list.Last().Add(new Vector2(58f, -200f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(370, 864, 132, 122), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(0f, 251.2004f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-51f, -298f));
		list.Last().Add(new Vector2(-50f, -210f));
		list.Last().Add(new Vector2(49f, -209f));
		list.Last().Add(new Vector2(49f, -299f));
		list3.Add(2);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateWaitChair(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(742, 1088, 192, 209), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(4.800001f, 92.79995f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(40f, -183f));
		list.Last().Add(new Vector2(-50f, -182f));
		list.Last().Add(new Vector2(-64f, -171f));
		list.Last().Add(new Vector2(-65f, -143f));
		list.Last().Add(new Vector2(-82f, -142f));
		list.Last().Add(new Vector2(-80f, -4f));
		list.Last().Add(new Vector2(-64f, -3f));
		list.Last().Add(new Vector2(-63f, -53f));
		list.Last().Add(new Vector2(51f, -52f));
		list.Last().Add(new Vector2(51f, -4f));
		list.Last().Add(new Vector2(68f, -4f));
		list.Last().Add(new Vector2(68f, -142f));
		list.Last().Add(new Vector2(52f, -142f));
		list.Last().Add(new Vector2(53f, -173f));
		list3.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateFilledWaitChair(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(739, 1087, 195, 213), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(3.200002f, 91.19995f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-77f, -4f));
		list.Last().Add(new Vector2(-61f, -4f));
		list.Last().Add(new Vector2(-60f, -54f));
		list.Last().Add(new Vector2(55f, -53f));
		list.Last().Add(new Vector2(55f, -5f));
		list.Last().Add(new Vector2(71f, -3f));
		list.Last().Add(new Vector2(71f, -141f));
		list.Last().Add(new Vector2(55f, -141f));
		list.Last().Add(new Vector2(56f, -170f));
		list.Last().Add(new Vector2(42f, -183f));
		list.Last().Add(new Vector2(-45f, -182f));
		list.Last().Add(new Vector2(-61f, -173f));
		list.Last().Add(new Vector2(-62f, -141f));
		list.Last().Add(new Vector2(-78f, -142f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(728, 910, 94, 141), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(32f, 49.59999f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-40f, -106f));
		list.Last().Add(new Vector2(-55f, -96f));
		list.Last().Add(new Vector2(-58f, -76f));
		list.Last().Add(new Vector2(-53f, -3f));
		list.Last().Add(new Vector2(-1f, -1f));
		list.Last().Add(new Vector2(-5f, -22f));
		list.Last().Add(new Vector2(-3f, -93f));
		list.Last().Add(new Vector2(-18f, -107f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(836, 910, 90, 136), default(Vector2), 0.05999999f));
		list2.Last().Last().Origin = new Vector2(-27.2f, 52.79998f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(3f, -5f));
		list.Last().Add(new Vector2(55f, -4f));
		list.Last().Add(new Vector2(49f, -24f));
		list.Last().Add(new Vector2(54f, -88f));
		list.Last().Add(new Vector2(43f, -100f));
		list.Last().Add(new Vector2(26f, -108f));
		list.Last().Add(new Vector2(5f, -99f));
		list.Last().Add(new Vector2(4f, -82f));
		list.Last().Add(new Vector2(7f, -30f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(549, 1039, 161, 204), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(3.200002f, 152f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-46f, -235f));
		list.Last().Add(new Vector2(-58f, -75f));
		list.Last().Add(new Vector2(51f, -78f));
		list.Last().Add(new Vector2(41f, -232f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(565, 885, 111, 144), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(0f, 272.0005f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-34f, -256f));
		list.Last().Add(new Vector2(-18f, -248f));
		list.Last().Add(new Vector2(-27f, -226f));
		list.Last().Add(new Vector2(24f, -224f));
		list.Last().Add(new Vector2(18f, -251f));
		list.Last().Add(new Vector2(31f, -253f));
		list.Last().Add(new Vector2(30f, -296f));
		list.Last().Add(new Vector2(33f, -298f));
		list.Last().Add(new Vector2(32f, -319f));
		list.Last().Add(new Vector2(-2f, -328f));
		list.Last().Add(new Vector2(-36f, -318f));
		list.Last().Add(new Vector2(-39f, -295f));
		list.Last().Add(new Vector2(-35f, -292f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(839, 741, 101, 140), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(52.79999f, 179.2001f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-37f, -233f));
		list.Last().Add(new Vector2(-75f, -159f));
		list.Last().Add(new Vector2(-80f, -156f));
		list.Last().Add(new Vector2(-81f, -127f));
		list.Last().Add(new Vector2(-47f, -126f));
		list.Last().Add(new Vector2(-51f, -139f));
		list.Last().Add(new Vector2(-30f, -182f));
		list.Last().Add(new Vector2(-25f, -214f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(950, 747, 103, 132), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(-52.79998f, 174.4001f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(31f, -230f));
		list.Last().Add(new Vector2(22f, -222f));
		list.Last().Add(new Vector2(17f, -211f));
		list.Last().Add(new Vector2(47f, -148f));
		list.Last().Add(new Vector2(49f, -126f));
		list.Last().Add(new Vector2(85f, -123f));
		list.Last().Add(new Vector2(82f, -154f));
		list.Last().Add(new Vector2(76f, -154f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(2);
		list3.Add(3);
		list4.Add(new Vector2(27f, -88f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(3);
		list4.Add(new Vector2(-29f, -88f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(3);
		list3.Add(4);
		list4.Add(new Vector2(-2f, -226f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		list3.Add(3);
		list3.Add(5);
		list4.Add(new Vector2(-33f, -213f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(3);
		list3.Add(6);
		list4.Add(new Vector2(29f, -212f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateSmallTable(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(965, 949, 185, 132), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 49.59999f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-64f, -3f));
		list.Last().Add(new Vector2(-37f, -2f));
		list.Last().Add(new Vector2(-46f, -73f));
		list.Last().Add(new Vector2(43f, -72f));
		list.Last().Add(new Vector2(35f, -3f));
		list.Last().Add(new Vector2(68f, -2f));
		list.Last().Add(new Vector2(60f, -72f));
		list.Last().Add(new Vector2(71f, -73f));
		list.Last().Add(new Vector2(72f, -97f));
		list.Last().Add(new Vector2(-73f, -99f));
		list.Last().Add(new Vector2(-74f, -75f));
		list.Last().Add(new Vector2(-61f, -73f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1239, 8, 88, 106), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(36.8f, 140.8f);
		list4.Add(MassTypes.ULTRALIGHT_MASS);
		list.Last().Add(new Vector2(-67f, -133f));
		list.Last().Add(new Vector2(-67f, -105f));
		list.Last().Add(new Vector2(-8f, -105f));
		list.Last().Add(new Vector2(-7f, -132f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1255, 127, 59, 92), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(47.99999f, 164.8f);
		list4.Add(MassTypes.ULTRALIGHT_MASS);
		list.Last().Add(new Vector2(-62f, -197f));
		list.Last().Add(new Vector2(-61f, -138f));
		list.Last().Add(new Vector2(-38f, -138f));
		list.Last().Add(new Vector2(-38f, -198f));
		list3.Add(2);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1342, 110, 55, 106), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(17.6f, 177.6001f);
		list4.Add(MassTypes.ULTRALIGHT_MASS);
		list.Last().Add(new Vector2(-33f, -210f));
		list.Last().Add(new Vector2(-34f, -140f));
		list.Last().Add(new Vector2(-7f, -139f));
		list.Last().Add(new Vector2(-6f, -211f));
		list3.Add(3);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateReceptionDesk(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1296, 468, 407, 215), default(Vector2), 0.05999999f));
		list2.Last().Last().Origin = new Vector2(0f, 84.79996f);
		list7.Add(MassTypes.ULTRAHEAVY_MASS);
		list.Last().Add(new Vector2(-187f, -175f));
		list.Last().Add(new Vector2(-188f, -152f));
		list.Last().Add(new Vector2(-172f, -149f));
		list.Last().Add(new Vector2(-170f, -4f));
		list.Last().Add(new Vector2(165f, -3f));
		list.Last().Add(new Vector2(167f, -150f));
		list.Last().Add(new Vector2(181f, -150f));
		list.Last().Add(new Vector2(180f, -174f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1111, 506, 162, 169), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(0f, 185.6001f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-44f, -247f));
		list.Last().Add(new Vector2(-42f, -237f));
		list.Last().Add(new Vector2(-51f, -237f));
		list.Last().Add(new Vector2(-62f, -123f));
		list.Last().Add(new Vector2(-41f, -122f));
		list.Last().Add(new Vector2(-42f, -167f));
		list.Last().Add(new Vector2(-36f, -190f));
		list.Last().Add(new Vector2(-24f, -149f));
		list.Last().Add(new Vector2(-34f, -120f));
		list.Last().Add(new Vector2(35f, -118f));
		list.Last().Add(new Vector2(23f, -143f));
		list.Last().Add(new Vector2(33f, -186f));
		list.Last().Add(new Vector2(38f, -121f));
		list.Last().Add(new Vector2(55f, -119f));
		list.Last().Add(new Vector2(57f, -148f));
		list.Last().Add(new Vector2(47f, -236f));
		list.Last().Add(new Vector2(39f, -236f));
		list.Last().Add(new Vector2(42f, -242f));
		list.Last().Add(new Vector2(2f, -256f));
		list.Last().Add(new Vector2(-18f, -254f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1115, 348, 139, 145), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(9.6f, 288.0005f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-21f, -268f));
		list.Last().Add(new Vector2(-27f, -281f));
		list.Last().Add(new Vector2(-47f, -274f));
		list.Last().Add(new Vector2(-59f, -288f));
		list.Last().Add(new Vector2(-46f, -288f));
		list.Last().Add(new Vector2(-36f, -319f));
		list.Last().Add(new Vector2(-39f, -342f));
		list.Last().Add(new Vector2(-9f, -344f));
		list.Last().Add(new Vector2(5f, -340f));
		list.Last().Add(new Vector2(17f, -343f));
		list.Last().Add(new Vector2(28f, -337f));
		list.Last().Add(new Vector2(22f, -312f));
		list.Last().Add(new Vector2(27f, -292f));
		list.Last().Add(new Vector2(40f, -296f));
		list.Last().Add(new Vector2(34f, -281f));
		list.Last().Add(new Vector2(17f, -276f));
		list.Last().Add(new Vector2(12f, -268f));
		list.Last().Add(new Vector2(8f, -236f));
		list.Last().Add(new Vector2(-18f, -235f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1403, 401, 83, 52), default(Vector2), 0.06999999f));
		list2.Last().Last().Origin = new Vector2(-89.59995f, 184.0001f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(60f, -187f));
		list.Last().Add(new Vector2(63f, -180f));
		list.Last().Add(new Vector2(114f, -178f));
		list.Last().Add(new Vector2(115f, -196f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1494, 275, 189, 193), default(Vector2), 0.07999999f));
		list2.Last().Last().Origin = new Vector2(-127.9999f, 257.6004f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(119f, -188f));
		list.Last().Add(new Vector2(120f, -181f));
		list.Last().Add(new Vector2(195f, -180f));
		list.Last().Add(new Vector2(196f, -190f));
		list.Last().Add(new Vector2(172f, -197f));
		list.Last().Add(new Vector2(172f, -204f));
		list.Last().Add(new Vector2(201f, -204f));
		list.Last().Add(new Vector2(199f, -283f));
		list.Last().Add(new Vector2(113f, -298f));
		list.Last().Add(new Vector2(112f, -204f));
		list.Last().Add(new Vector2(142f, -201f));
		list.Last().Add(new Vector2(141f, -196f));
		list.Last().Add(new Vector2(119f, -190f));
		list6.Add(2);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1272, 395, 119, 67), default(Vector2), 0.08999999f));
		list2.Last().Last().Origin = new Vector2(137.5999f, 192.0002f);
		list7.Add(MassTypes.ULTRALIGHT_MASS);
		list.Last().Add(new Vector2(-181f, -206f));
		list.Last().Add(new Vector2(-180f, -183f));
		list.Last().Add(new Vector2(-99f, -182f));
		list.Last().Add(new Vector2(-99f, -209f));
		list6.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1257, 218, 65, 96), default(Vector2), 0.09999999f));
		list2.Last().Last().Origin = new Vector2(158.4f, 249.6004f);
		list7.Add(MassTypes.ULTRALIGHT_MASS);
		list.Last().Add(new Vector2(-178f, -280f));
		list.Last().Add(new Vector2(-176f, -219f));
		list.Last().Add(new Vector2(-141f, -219f));
		list.Last().Add(new Vector2(-141f, -281f));
		list6.Add(5);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1339, 229, 64, 85), default(Vector2), 0.11f));
		list2.Last().Last().Origin = new Vector2(115.1999f, 243.2003f);
		list7.Add(MassTypes.ULTRALIGHT_MASS);
		list.Last().Add(new Vector2(-133f, -272f));
		list.Last().Add(new Vector2(-132f, -217f));
		list.Last().Add(new Vector2(-100f, -216f));
		list.Last().Add(new Vector2(-101f, -272f));
		list6.Add(5);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1111, 506, 162, 169), default(Vector2), -1.05f));
		list2.Last().Last().Origin = new Vector2(0f, 185.6001f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1115, 348, 139, 145), default(Vector2), -1.04f));
		list2.Last().Last().Origin = new Vector2(9.6f, 288.0005f);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(-3f, -132f));
		list5.Add(PhysicsJointType.ULTRAFIRM_JOINT);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(-4f, -239f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateElderly(PhysicsOutfit outfit)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7a: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(841, 244, 98, 107), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(73.59997f, 35.2f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-62f, -75f));
		list.Last().Add(new Vector2(-72f, -18f));
		list.Last().Add(new Vector2(-105f, -12f));
		list.Last().Add(new Vector2(-101f, 0f));
		list.Last().Add(new Vector2(-54f, -1f));
		list.Last().Add(new Vector2(-45f, -74f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(965, 239, 86, 108), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(-43.19999f, 40f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(52f, -18f));
		list.Last().Add(new Vector2(20f, -15f));
		list.Last().Add(new Vector2(23f, -3f));
		list.Last().Add(new Vector2(69f, -1f));
		list.Last().Add(new Vector2(70f, -14f));
		list.Last().Add(new Vector2(56f, -77f));
		list.Last().Add(new Vector2(29f, -77f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(874, 514, 176, 207), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(9.6f, 144f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-78f, -204f));
		list.Last().Add(new Vector2(-75f, -183f));
		list.Last().Add(new Vector2(-40f, -161f));
		list.Last().Add(new Vector2(-28f, -142f));
		list.Last().Add(new Vector2(-68f, -57f));
		list.Last().Add(new Vector2(60f, -64f));
		list.Last().Add(new Vector2(28f, -186f));
		list.Last().Add(new Vector2(-49f, -235f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(885, 111, 124, 120), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(92.79995f, 241.6003f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-51f, -227f));
		list.Last().Add(new Vector2(-72f, -240f));
		list.Last().Add(new Vector2(-71f, -266f));
		list.Last().Add(new Vector2(-83f, -264f));
		list.Last().Add(new Vector2(-107f, -278f));
		list.Last().Add(new Vector2(-120f, -275f));
		list.Last().Add(new Vector2(-127f, -278f));
		list.Last().Add(new Vector2(-128f, -247f));
		list.Last().Add(new Vector2(-122f, -242f));
		list.Last().Add(new Vector2(-134f, -227f));
		list.Last().Add(new Vector2(-123f, -225f));
		list.Last().Add(new Vector2(-124f, -213f));
		list.Last().Add(new Vector2(-117f, -204f));
		list.Last().Add(new Vector2(-88f, -204f));
		list.Last().Add(new Vector2(-85f, -214f));
		list.Last().Add(new Vector2(-63f, -202f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(875, 365, 213, 127), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(103.9999f, 164.8f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-183f, -197f));
		list.Last().Add(new Vector2(-159f, -206f));
		list.Last().Add(new Vector2(-145f, -187f));
		list.Last().Add(new Vector2(-122f, -175f));
		list.Last().Add(new Vector2(-118f, -179f));
		list.Last().Add(new Vector2(-87f, -166f));
		list.Last().Add(new Vector2(-39f, -212f));
		list.Last().Add(new Vector2(-32f, -213f));
		list.Last().Add(new Vector2(-14f, -199f));
		list.Last().Add(new Vector2(-19f, -187f));
		list.Last().Add(new Vector2(-84f, -116f));
		list.Last().Add(new Vector2(-137f, -140f));
		list.Last().Add(new Vector2(-128f, -162f));
		list.Last().Add(new Vector2(-150f, -171f));
		list.Last().Add(new Vector2(-179f, -177f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1078, 19, 136, 301), default(Vector2), 0f));
		list2.Last().Last().Origin = new Vector2(185.6001f, 135.9999f);
		list7.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-237f, -267f));
		list.Last().Add(new Vector2(-237f, -235f));
		list.Last().Add(new Vector2(-192f, -238f));
		list.Last().Add(new Vector2(-191f, -163f));
		list.Last().Add(new Vector2(-207f, -163f));
		list.Last().Add(new Vector2(-206f, -132f));
		list.Last().Add(new Vector2(-191f, -133f));
		list.Last().Add(new Vector2(-190f, -42f));
		list.Last().Add(new Vector2(-228f, -42f));
		list.Last().Add(new Vector2(-230f, -21f));
		list.Last().Add(new Vector2(-228f, -12f));
		list.Last().Add(new Vector2(-222f, -5f));
		list.Last().Add(new Vector2(-213f, 2f));
		list.Last().Add(new Vector2(-202f, -4f));
		list.Last().Add(new Vector2(-200f, -17f));
		list.Last().Add(new Vector2(-198f, -20f));
		list.Last().Add(new Vector2(-163f, -23f));
		list.Last().Add(new Vector2(-162f, -9f));
		list.Last().Add(new Vector2(-153f, 2f));
		list.Last().Add(new Vector2(-139f, -2f));
		list.Last().Add(new Vector2(-138f, -21f));
		list.Last().Add(new Vector2(-132f, -25f));
		list.Last().Add(new Vector2(-135f, -43f));
		list.Last().Add(new Vector2(-178f, -41f));
		list.Last().Add(new Vector2(-177f, -132f));
		list.Last().Add(new Vector2(-159f, -131f));
		list.Last().Add(new Vector2(-162f, -162f));
		list.Last().Add(new Vector2(-176f, -161f));
		list.Last().Add(new Vector2(-177f, -243f));
		list.Last().Add(new Vector2(-134f, -233f));
		list.Last().Add(new Vector2(-136f, -266f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(917, 20, 74, 89), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(208.0002f, 225.6003f);
		list7.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-223f, -251f));
		list.Last().Add(new Vector2(-227f, -205f));
		list.Last().Add(new Vector2(-190f, -204f));
		list.Last().Add(new Vector2(-192f, -251f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(0);
		list3.Add(2);
		list4.Add(new Vector2(-55f, -65f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(44f, -72f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		list3.Add(2);
		list3.Add(3);
		list4.Add(new Vector2(-57f, -207f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		list3.Add(4);
		list3.Add(2);
		list4.Add(new Vector2(-35f, -194f));
		list5.Add(PhysicsJointType.FLOPPY_JOINT);
		list3.Add(5);
		list3.Add(4);
		list4.Add(new Vector2(-183f, -194f));
		list5.Add(PhysicsJointType.FLOPPY_JOINT);
		list3.Add(6);
		list3.Add(5);
		list4.Add(new Vector2(-210f, -245f));
		list5.Add(PhysicsJointType.FLOPPY_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateCrutches(PhysicsOutfit outfit)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2110, 20, 114, 160), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(-54.39998f, 63.99998f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(25f, -120f));
		list.Last().Add(new Vector2(61f, -14f));
		list.Last().Add(new Vector2(27f, -17f));
		list.Last().Add(new Vector2(26f, -2f));
		list.Last().Add(new Vector2(97f, -3f));
		list.Last().Add(new Vector2(47f, -131f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1768, 10, 170, 221), default(Vector2), 0.05999999f));
		list2.Last().Last().Origin = new Vector2(-1.600001f, 188.8001f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-65f, -257f));
		list.Last().Add(new Vector2(-40f, -96f));
		list.Last().Add(new Vector2(69f, -113f));
		list.Last().Add(new Vector2(-20f, -287f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1951, 31, 134, 174), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(38.4f, 70.39997f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-32f, -2f));
		list.Last().Add(new Vector2(-20f, -8f));
		list.Last().Add(new Vector2(0f, -74f));
		list.Last().Add(new Vector2(-10f, -77f));
		list.Last().Add(new Vector2(12f, -127f));
		list.Last().Add(new Vector2(-20f, -138f));
		list.Last().Add(new Vector2(-33f, -84f));
		list.Last().Add(new Vector2(-36f, -84f));
		list.Last().Add(new Vector2(-50f, -46f));
		list.Last().Add(new Vector2(-69f, -57f));
		list.Last().Add(new Vector2(-83f, -51f));
		list.Last().Add(new Vector2(-93f, -29f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1438, 21, 122, 165), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(62.39998f, 312.0006f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-96f, -288f));
		list.Last().Add(new Vector2(-56f, -288f));
		list.Last().Add(new Vector2(-53f, -248f));
		list.Last().Add(new Vector2(-25f, -282f));
		list.Last().Add(new Vector2(-26f, -317f));
		list.Last().Add(new Vector2(-21f, -315f));
		list.Last().Add(new Vector2(-19f, -344f));
		list.Last().Add(new Vector2(-30f, -364f));
		list.Last().Add(new Vector2(-80f, -365f));
		list.Last().Add(new Vector2(-85f, -378f));
		list.Last().Add(new Vector2(-94f, -368f));
		list.Last().Add(new Vector2(-94f, -345f));
		list.Last().Add(new Vector2(-91f, -340f));
		list.Last().Add(new Vector2(-106f, -317f));
		list.Last().Add(new Vector2(-94f, -311f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1591, 16, 143, 184), default(Vector2), 0.09999999f));
		list2.Last().Last().Origin = new Vector2(67.19997f, 198.4002f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-36f, -272f));
		list.Last().Add(new Vector2(-104f, -165f));
		list.Last().Add(new Vector2(-100f, -159f));
		list.Last().Add(new Vector2(-123f, -144f));
		list.Last().Add(new Vector2(-112f, -128f));
		list.Last().Add(new Vector2(-92f, -125f));
		list.Last().Add(new Vector2(-82f, -150f));
		list.Last().Add(new Vector2(-76f, -142f));
		list.Last().Add(new Vector2(-10f, -255f));
		list.Last().Add(new Vector2(-17f, -271f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1735, 239, 242, 291), default(Vector2), 0.08999999f));
		list2.Last().Last().Origin = new Vector2(110.3999f, 126.3999f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-196f, -2f));
		list.Last().Add(new Vector2(-212f, -10f));
		list.Last().Add(new Vector2(-196f, -29f));
		list.Last().Add(new Vector2(-149f, -95f));
		list.Last().Add(new Vector2(-142f, -160f));
		list.Last().Add(new Vector2(-82f, -262f));
		list.Last().Add(new Vector2(-4f, -214f));
		list.Last().Add(new Vector2(-10f, -204f));
		list.Last().Add(new Vector2(-18f, -207f));
		list.Last().Add(new Vector2(-72f, -124f));
		list.Last().Add(new Vector2(-127f, -84f));
		list.Last().Add(new Vector2(-183f, -15f));
		list.Last().Add(new Vector2(-189f, -3f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2110, 20, 114, 160), default(Vector2), -1.01f));
		list2.Last().Last().Origin = new Vector2(-54.39998f, 63.99998f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1768, 10, 170, 221), default(Vector2), -1.06f));
		list2.Last().Last().Origin = new Vector2(-1.600001f, 188.8001f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1951, 31, 134, 174), default(Vector2), -1.02f));
		list2.Last().Last().Origin = new Vector2(38.4f, 70.39997f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1438, 21, 122, 165), default(Vector2), -1.03f));
		list2.Last().Last().Origin = new Vector2(62.39998f, 312.0006f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1591, 16, 143, 184), default(Vector2), -1.1f));
		list2.Last().Last().Origin = new Vector2(67.19997f, 198.4002f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1735, 239, 242, 291), default(Vector2), -1.09f));
		list2.Last().Last().Origin = new Vector2(110.3999f, 126.3999f);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(39f, -120f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(-10f, -119f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(3);
		list4.Add(new Vector2(-42f, -270f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(4);
		list4.Add(new Vector2(-28f, -259f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(4);
		list3.Add(5);
		list4.Add(new Vector2(-104f, -144f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateMetalCabinet(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1797, 575, 211, 358), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 164.8f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-87f, -326f));
		list.Last().Add(new Vector2(-87f, -3f));
		list.Last().Add(new Vector2(90f, -3f));
		list.Last().Add(new Vector2(89f, -326f));
		list3.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateGurney(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1162, 857, 417, 190), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 78.39996f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-180f, -153f));
		list.Last().Add(new Vector2(-179f, -130f));
		list.Last().Add(new Vector2(-158f, -128f));
		list.Last().Add(new Vector2(-113f, -79f));
		list.Last().Add(new Vector2(-155f, -46f));
		list.Last().Add(new Vector2(-179f, -45f));
		list.Last().Add(new Vector2(-182f, -23f));
		list.Last().Add(new Vector2(-173f, -14f));
		list.Last().Add(new Vector2(-165f, -5f));
		list.Last().Add(new Vector2(-155f, -5f));
		list.Last().Add(new Vector2(-147f, -18f));
		list.Last().Add(new Vector2(-140f, -21f));
		list.Last().Add(new Vector2(150f, -22f));
		list.Last().Add(new Vector2(157f, -9f));
		list.Last().Add(new Vector2(167f, -5f));
		list.Last().Add(new Vector2(177f, -7f));
		list.Last().Add(new Vector2(181f, -19f));
		list.Last().Add(new Vector2(185f, -21f));
		list.Last().Add(new Vector2(184f, -45f));
		list.Last().Add(new Vector2(155f, -45f));
		list.Last().Add(new Vector2(129f, -77f));
		list.Last().Add(new Vector2(164f, -128f));
		list.Last().Add(new Vector2(185f, -128f));
		list.Last().Add(new Vector2(183f, -154f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1119, 693, 460, 145), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(-6.399999f, 193.6002f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-197f, -208f));
		list.Last().Add(new Vector2(-198f, -161f));
		list.Last().Add(new Vector2(-190f, -149f));
		list.Last().Add(new Vector2(-176f, -157f));
		list.Last().Add(new Vector2(107f, -154f));
		list.Last().Add(new Vector2(107f, -166f));
		list.Last().Add(new Vector2(186f, -160f));
		list.Last().Add(new Vector2(201f, -150f));
		list.Last().Add(new Vector2(207f, -178f));
		list.Last().Add(new Vector2(210f, -211f));
		list.Last().Add(new Vector2(198f, -236f));
		list.Last().Add(new Vector2(185f, -227f));
		list.Last().Add(new Vector2(160f, -226f));
		list.Last().Add(new Vector2(143f, -237f));
		list.Last().Add(new Vector2(136f, -241f));
		list.Last().Add(new Vector2(124f, -232f));
		list.Last().Add(new Vector2(116f, -223f));
		list.Last().Add(new Vector2(119f, -196f));
		list.Last().Add(new Vector2(106f, -197f));
		list.Last().Add(new Vector2(102f, -211f));
		list.Last().Add(new Vector2(22f, -222f));
		list.Last().Add(new Vector2(-42f, -216f));
		list.Last().Add(new Vector2(-72f, -203f));
		list.Last().Add(new Vector2(-78f, -194f));
		list.Last().Add(new Vector2(-144f, -186f));
		list.Last().Add(new Vector2(-178f, -215f));
		list.Last().Add(new Vector2(-199f, -208f));
		list3.Add(1);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1162, 857, 417, 190), default(Vector2), -0.99f));
		list2.Last().Last().Origin = new Vector2(0f, 78.39996f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1119, 693, 460, 145), default(Vector2), -0.98f));
		list2.Last().Last().Origin = new Vector2(-6.399999f, 193.6002f);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateCabinet(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1605, 828, 168, 198), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 83.19996f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-67f, -165f));
		list.Last().Add(new Vector2(-68f, -145f));
		list.Last().Add(new Vector2(-59f, -145f));
		list.Last().Add(new Vector2(-58f, -3f));
		list.Last().Add(new Vector2(61f, -4f));
		list.Last().Add(new Vector2(60f, -143f));
		list.Last().Add(new Vector2(67f, -144f));
		list.Last().Add(new Vector2(67f, -166f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1591, 713, 92, 105), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(41.59999f, 201.6002f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-66f, -218f));
		list.Last().Add(new Vector2(-60f, -204f));
		list.Last().Add(new Vector2(-63f, -204f));
		list.Last().Add(new Vector2(-65f, -192f));
		list.Last().Add(new Vector2(-58f, -191f));
		list.Last().Add(new Vector2(-56f, -174f));
		list.Last().Add(new Vector2(-30f, -173f));
		list.Last().Add(new Vector2(-24f, -192f));
		list.Last().Add(new Vector2(-19f, -191f));
		list.Last().Add(new Vector2(-21f, -203f));
		list.Last().Add(new Vector2(-13f, -219f));
		list.Last().Add(new Vector2(-17f, -221f));
		list.Last().Add(new Vector2(-13f, -232f));
		list.Last().Add(new Vector2(-35f, -236f));
		list.Last().Add(new Vector2(-45f, -234f));
		list.Last().Add(new Vector2(-66f, -232f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1693, 750, 75, 64), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-25.6f, 187.2001f);
		list4.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(0f, -184f));
		list.Last().Add(new Vector2(-1f, -174f));
		list.Last().Add(new Vector2(50f, -172f));
		list.Last().Add(new Vector2(48f, -185f));
		list.Last().Add(new Vector2(40f, -197f));
		list.Last().Add(new Vector2(10f, -197f));
		list.Last().Add(new Vector2(2f, -189f));
		list3.Add(2);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateLunchLady(PhysicsOutfit outfit)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2542, 205, 124, 139), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(49.59999f, 46.39999f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-88f, -93f));
		list.Last().Add(new Vector2(-89f, -2f));
		list.Last().Add(new Vector2(-23f, -1f));
		list.Last().Add(new Vector2(-22f, -20f));
		list.Last().Add(new Vector2(-64f, -21f));
		list.Last().Add(new Vector2(-58f, -93f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2361, 12, 155, 228), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(55.99998f, 171.2001f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-97f, -257f));
		list.Last().Add(new Vector2(-100f, -166f));
		list.Last().Add(new Vector2(-114f, -85f));
		list.Last().Add(new Vector2(-92f, -80f));
		list.Last().Add(new Vector2(-35f, -79f));
		list.Last().Add(new Vector2(-3f, -99f));
		list.Last().Add(new Vector2(-37f, -169f));
		list.Last().Add(new Vector2(-21f, -209f));
		list.Last().Add(new Vector2(-49f, -253f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2257, 18, 93, 190), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(67.19997f, 176.0001f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-87f, -242f));
		list.Last().Add(new Vector2(-84f, -126f));
		list.Last().Add(new Vector2(-73f, -109f));
		list.Last().Add(new Vector2(-47f, -120f));
		list.Last().Add(new Vector2(-60f, -137f));
		list.Last().Add(new Vector2(-44f, -139f));
		list.Last().Add(new Vector2(-66f, -245f));
		list.Last().Add(new Vector2(-78f, -249f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2519, 39, 128, 138), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(71.99997f, 291.2005f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-93f, -296f));
		list.Last().Add(new Vector2(-90f, -240f));
		list.Last().Add(new Vector2(-56f, -239f));
		list.Last().Add(new Vector2(-57f, -271f));
		list.Last().Add(new Vector2(-33f, -268f));
		list.Last().Add(new Vector2(-33f, -288f));
		list.Last().Add(new Vector2(-27f, -291f));
		list.Last().Add(new Vector2(-35f, -310f));
		list.Last().Add(new Vector2(-31f, -338f));
		list.Last().Add(new Vector2(-50f, -346f));
		list.Last().Add(new Vector2(-100f, -347f));
		list.Last().Add(new Vector2(-116f, -330f));
		list.Last().Add(new Vector2(-104f, -295f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2055, 366, 194, 258), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(-86.39996f, 111.9999f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(7f, -222f));
		list.Last().Add(new Vector2(9f, -202f));
		list.Last().Add(new Vector2(28f, -202f));
		list.Last().Add(new Vector2(28f, -2f));
		list.Last().Add(new Vector2(165f, -2f));
		list.Last().Add(new Vector2(163f, -202f));
		list.Last().Add(new Vector2(166f, -201f));
		list.Last().Add(new Vector2(165f, -222f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2104, 222, 116, 124), default(Vector2), 0.06999999f));
		list2.Last().Last().Origin = new Vector2(-124.7999f, 268.8004f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(86f, -246f));
		list.Last().Add(new Vector2(87f, -228f));
		list.Last().Add(new Vector2(157f, -229f));
		list.Last().Add(new Vector2(158f, -316f));
		list.Last().Add(new Vector2(144f, -314f));
		list.Last().Add(new Vector2(146f, -296f));
		list.Last().Add(new Vector2(137f, -294f));
		list.Last().Add(new Vector2(99f, -248f));
		list6.Add(2);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2542, 205, 124, 139), default(Vector2), -0.99f));
		list2.Last().Last().Origin = new Vector2(49.59999f, 46.39999f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2361, 12, 155, 228), default(Vector2), -0.98f));
		list2.Last().Last().Origin = new Vector2(55.99998f, 171.2001f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2257, 18, 93, 190), default(Vector2), -0.97f));
		list2.Last().Last().Origin = new Vector2(67.19997f, 176.0001f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2519, 39, 128, 138), default(Vector2), -0.99f));
		list2.Last().Last().Origin = new Vector2(71.99997f, 291.2005f);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(-75f, -92f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(-73f, -236f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(3);
		list4.Add(new Vector2(-76f, -243f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateCrabMeal(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff5: Unknown result type (might be due to invalid IL or missing references)
		//IL_100f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_1065: Unknown result type (might be due to invalid IL or missing references)
		//IL_106c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1072: Unknown result type (might be due to invalid IL or missing references)
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1108: Unknown result type (might be due to invalid IL or missing references)
		//IL_1122: Unknown result type (might be due to invalid IL or missing references)
		//IL_113c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1156: Unknown result type (might be due to invalid IL or missing references)
		//IL_1170: Unknown result type (might be due to invalid IL or missing references)
		//IL_118a: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11be: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_120c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1245: Unknown result type (might be due to invalid IL or missing references)
		//IL_124c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1252: Unknown result type (might be due to invalid IL or missing references)
		//IL_1278: Unknown result type (might be due to invalid IL or missing references)
		//IL_129a: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_131e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1325: Unknown result type (might be due to invalid IL or missing references)
		//IL_132b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1351: Unknown result type (might be due to invalid IL or missing references)
		//IL_1373: Unknown result type (might be due to invalid IL or missing references)
		//IL_138d: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_140f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1429: Unknown result type (might be due to invalid IL or missing references)
		//IL_1443: Unknown result type (might be due to invalid IL or missing references)
		//IL_145d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1477: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Unknown result type (might be due to invalid IL or missing references)
		//IL_151c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1536: Unknown result type (might be due to invalid IL or missing references)
		//IL_1550: Unknown result type (might be due to invalid IL or missing references)
		//IL_156a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1584: Unknown result type (might be due to invalid IL or missing references)
		//IL_159e: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1708: Unknown result type (might be due to invalid IL or missing references)
		//IL_170f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_173b: Unknown result type (might be due to invalid IL or missing references)
		//IL_175e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1789: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17df: Unknown result type (might be due to invalid IL or missing references)
		//IL_180a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1836: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2300, 1198, 396, 224), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(1.599998f, 89.59995f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-135f, -159f));
		list.Last().Add(new Vector2(-142f, -1f));
		list.Last().Add(new Vector2(-106f, -1f));
		list.Last().Add(new Vector2(-116f, -159f));
		list.Last().Add(new Vector2(112f, -161f));
		list.Last().Add(new Vector2(104f, -3f));
		list.Last().Add(new Vector2(137f, -2f));
		list.Last().Add(new Vector2(128f, -161f));
		list.Last().Add(new Vector2(173f, -161f));
		list.Last().Add(new Vector2(174f, -187f));
		list.Last().Add(new Vector2(-177f, -186f));
		list.Last().Add(new Vector2(-176f, -164f));
		list.Last().Add(new Vector2(-134f, -163f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2200, 887, 214, 172), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(233.6003f, 75.19997f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-319f, -137f));
		list.Last().Add(new Vector2(-320f, -115f));
		list.Last().Add(new Vector2(-307f, -105f));
		list.Last().Add(new Vector2(-209f, -112f));
		list.Last().Add(new Vector2(-202f, -14f));
		list.Last().Add(new Vector2(-148f, -11f));
		list.Last().Add(new Vector2(-148f, -29f));
		list.Last().Add(new Vector2(-168f, -32f));
		list.Last().Add(new Vector2(-172f, -126f));
		list.Last().Add(new Vector2(-189f, -146f));
		list.Last().Add(new Vector2(-247f, -137f));
		list.Last().Add(new Vector2(-265f, -145f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2061, 854, 129, 194), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(278.4005f, 182.4001f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-309f, -257f));
		list.Last().Add(new Vector2(-326f, -113f));
		list.Last().Add(new Vector2(-237f, -140f));
		list.Last().Add(new Vector2(-256f, -253f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2204, 707, 199, 136), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(214.4002f, 208.0002f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-270f, -238f));
		list.Last().Add(new Vector2(-291f, -235f));
		list.Last().Add(new Vector2(-292f, -203f));
		list.Last().Add(new Vector2(-232f, -158f));
		list.Last().Add(new Vector2(-216f, -163f));
		list.Last().Add(new Vector2(-143f, -217f));
		list.Last().Add(new Vector2(-142f, -237f));
		list.Last().Add(new Vector2(-152f, -251f));
		list.Last().Add(new Vector2(-177f, -243f));
		list.Last().Add(new Vector2(-224f, -200f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2070, 713, 125, 148), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(265.6004f, 291.2005f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-299f, -307f));
		list.Last().Add(new Vector2(-304f, -248f));
		list.Last().Add(new Vector2(-275f, -249f));
		list.Last().Add(new Vector2(-262f, -269f));
		list.Last().Add(new Vector2(-233f, -266f));
		list.Last().Add(new Vector2(-233f, -288f));
		list.Last().Add(new Vector2(-226f, -287f));
		list.Last().Add(new Vector2(-234f, -306f));
		list.Last().Add(new Vector2(-231f, -311f));
		list.Last().Add(new Vector2(-231f, -329f));
		list.Last().Add(new Vector2(-256f, -347f));
		list.Last().Add(new Vector2(-283f, -345f));
		list.Last().Add(new Vector2(-300f, -332f));
		list.Last().Add(new Vector2(-302f, -312f));
		list.Last().Add(new Vector2(-298f, -302f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2054, 1073, 199, 307), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(286.4005f, 99.19994f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-347f, -230f));
		list.Last().Add(new Vector2(-345f, -74f));
		list.Last().Add(new Vector2(-337f, -73f));
		list.Last().Add(new Vector2(-344f, -1f));
		list.Last().Add(new Vector2(-314f, -3f));
		list.Last().Add(new Vector2(-323f, -73f));
		list.Last().Add(new Vector2(-246f, -73f));
		list.Last().Add(new Vector2(-251f, -2f));
		list.Last().Add(new Vector2(-217f, -1f));
		list.Last().Add(new Vector2(-228f, -71f));
		list.Last().Add(new Vector2(-222f, -71f));
		list.Last().Add(new Vector2(-225f, -99f));
		list.Last().Add(new Vector2(-331f, -97f));
		list.Last().Add(new Vector2(-325f, -228f));
		list6.Add(2);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2433, 876, 220, 187), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-224.0003f, 79.99996f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(146f, -33f));
		list.Last().Add(new Vector2(144f, -14f));
		list.Last().Add(new Vector2(208f, -12f));
		list.Last().Add(new Vector2(211f, -113f));
		list.Last().Add(new Vector2(292f, -105f));
		list.Last().Add(new Vector2(309f, -115f));
		list.Last().Add(new Vector2(309f, -148f));
		list.Last().Add(new Vector2(275f, -140f));
		list.Last().Add(new Vector2(213f, -146f));
		list.Last().Add(new Vector2(182f, -137f));
		list.Last().Add(new Vector2(168f, -114f));
		list.Last().Add(new Vector2(161f, -36f));
		list6.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2654, 876, 156, 175), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(-265.6004f, 182.4001f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(233f, -249f));
		list.Last().Add(new Vector2(216f, -179f));
		list.Last().Add(new Vector2(219f, -148f));
		list.Last().Add(new Vector2(313f, -121f));
		list.Last().Add(new Vector2(309f, -251f));
		list6.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2437, 711, 213, 139), default(Vector2), 0.05999999f));
		list2.Last().Last().Origin = new Vector2(-214.4002f, 209.6002f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(136f, -249f));
		list.Last().Add(new Vector2(148f, -219f));
		list.Last().Add(new Vector2(211f, -176f));
		list.Last().Add(new Vector2(234f, -175f));
		list.Last().Add(new Vector2(292f, -207f));
		list.Last().Add(new Vector2(295f, -228f));
		list.Last().Add(new Vector2(286f, -241f));
		list.Last().Add(new Vector2(270f, -239f));
		list.Last().Add(new Vector2(228f, -214f));
		list.Last().Add(new Vector2(178f, -247f));
		list.Last().Add(new Vector2(172f, -254f));
		list.Last().Add(new Vector2(149f, -259f));
		list6.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2658, 717, 131, 160), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-260.8004f, 292.8005f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(253f, -266f));
		list.Last().Add(new Vector2(252f, -236f));
		list.Last().Add(new Vector2(298f, -237f));
		list.Last().Add(new Vector2(292f, -288f));
		list.Last().Add(new Vector2(301f, -290f));
		list.Last().Add(new Vector2(306f, -308f));
		list.Last().Add(new Vector2(300f, -338f));
		list.Last().Add(new Vector2(275f, -357f));
		list.Last().Add(new Vector2(243f, -366f));
		list.Last().Add(new Vector2(218f, -347f));
		list.Last().Add(new Vector2(227f, -318f));
		list.Last().Add(new Vector2(227f, -308f));
		list.Last().Add(new Vector2(217f, -287f));
		list.Last().Add(new Vector2(228f, -291f));
		list.Last().Add(new Vector2(228f, -268f));
		list6.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2703, 1086, 199, 302), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(-286.4005f, 110.3999f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(318f, -228f));
		list.Last().Add(new Vector2(319f, -99f));
		list.Last().Add(new Vector2(214f, -97f));
		list.Last().Add(new Vector2(215f, -71f));
		list.Last().Add(new Vector2(222f, -72f));
		list.Last().Add(new Vector2(217f, -2f));
		list.Last().Add(new Vector2(246f, -1f));
		list.Last().Add(new Vector2(240f, -70f));
		list.Last().Add(new Vector2(318f, -73f));
		list.Last().Add(new Vector2(311f, -4f));
		list.Last().Add(new Vector2(342f, 0f));
		list.Last().Add(new Vector2(334f, -74f));
		list.Last().Add(new Vector2(335f, -74f));
		list.Last().Add(new Vector2(340f, -229f));
		list6.Add(4);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2415, 1132, 175, 49), default(Vector2), 0.05999999f));
		list2.Last().Last().Origin = new Vector2(12.8f, 196.8002f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-90f, -203f));
		list.Last().Add(new Vector2(-77f, -190f));
		list.Last().Add(new Vector2(51f, -191f));
		list.Last().Add(new Vector2(64f, -204f));
		list6.Add(5);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2510, 1497, 96, 75), default(Vector2), 0.06999999f));
		list2.Last().Last().Origin = new Vector2(55.99998f, 225.6003f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-88f, -239f));
		list.Last().Add(new Vector2(-92f, -219f));
		list.Last().Add(new Vector2(-57f, -207f));
		list.Last().Add(new Vector2(-21f, -223f));
		list.Last().Add(new Vector2(-23f, -240f));
		list.Last().Add(new Vector2(-31f, -241f));
		list.Last().Add(new Vector2(-47f, -233f));
		list.Last().Add(new Vector2(-45f, -223f));
		list.Last().Add(new Vector2(-64f, -224f));
		list.Last().Add(new Vector2(-68f, -236f));
		list.Last().Add(new Vector2(-86f, -241f));
		list6.Add(6);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2497, 1486, 126, 96), default(Vector2), 0.07999999f));
		list2.Last().Last().Origin = new Vector2(-44.79999f, 227.2003f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(10f, -238f));
		list.Last().Add(new Vector2(7f, -220f));
		list.Last().Add(new Vector2(39f, -207f));
		list.Last().Add(new Vector2(47f, -207f));
		list.Last().Add(new Vector2(80f, -224f));
		list.Last().Add(new Vector2(74f, -244f));
		list.Last().Add(new Vector2(52f, -235f));
		list.Last().Add(new Vector2(54f, -223f));
		list.Last().Add(new Vector2(32f, -226f));
		list.Last().Add(new Vector2(33f, -234f));
		list6.Add(7);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2510, 1497, 96, 75), default(Vector2), -0.93f));
		list2.Last().Last().Origin = new Vector2(55.99998f, 225.6003f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2497, 1486, 126, 96), default(Vector2), -0.92f));
		list2.Last().Last().Origin = new Vector2(-44.79999f, 227.2003f);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(-299f, -138f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(2);
		list3.Add(3);
		list4.Add(new Vector2(-275f, -220f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(2);
		list3.Add(4);
		list4.Add(new Vector2(-295f, -242f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(7);
		list3.Add(6);
		list4.Add(new Vector2(273f, -147f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(8);
		list3.Add(7);
		list4.Add(new Vector2(276f, -219f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(7);
		list3.Add(9);
		list4.Add(new Vector2(276f, -235f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateBuffet(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2297, 386, 483, 312), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 137.5999f);
		list4.Add(MassTypes.ULTRAHEAVY_MASS);
		list.Last().Add(new Vector2(-221f, -195f));
		list.Last().Add(new Vector2(-217f, -3f));
		list.Last().Add(new Vector2(216f, -3f));
		list.Last().Add(new Vector2(219f, -196f));
		list.Last().Add(new Vector2(211f, -274f));
		list.Last().Add(new Vector2(-205f, -277f));
		list3.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateGarbageCan(PhysicsOutfit outfit)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(607, 1516, 124, 111), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(0f, 38.4f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-23f, -82f));
		list.Last().Add(new Vector2(-40f, -83f));
		list.Last().Add(new Vector2(-25f, -1f));
		list.Last().Add(new Vector2(31f, -2f));
		list.Last().Add(new Vector2(41f, -82f));
		list.Last().Add(new Vector2(25f, -82f));
		list.Last().Add(new Vector2(22f, -68f));
		list.Last().Add(new Vector2(5f, -55f));
		list.Last().Add(new Vector2(-23f, -66f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(595, 1375, 67, 60), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-8f, 79.99996f);
		list4.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(5f, -101f));
		list.Last().Add(new Vector2(-6f, -72f));
		list.Last().Add(new Vector2(10f, -66f));
		list.Last().Add(new Vector2(24f, -88f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(631, 1308, 58, 55), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(12.8f, 94.39995f);
		list4.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-10f, -113f));
		list.Last().Add(new Vector2(-1f, -94f));
		list.Last().Add(new Vector2(-4f, -91f));
		list.Last().Add(new Vector2(-18f, -81f));
		list.Last().Add(new Vector2(-22f, -89f));
		list3.Add(2);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(675, 1370, 52, 59), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-3.2f, 119.9999f);
		list4.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-14f, -122f));
		list.Last().Add(new Vector2(3f, -112f));
		list.Last().Add(new Vector2(6f, -106f));
		list.Last().Add(new Vector2(19f, -120f));
		list.Last().Add(new Vector2(-1f, -138f));
		list3.Add(3);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateFilledBed(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1371, 1065, 306, 430), default(Vector2), SceneRenderer.GetRand(-5f, -5.5f)));
		list2.Last().Last().Origin = new Vector2(0f, 198.4002f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-137f, -115f));
		list.Last().Add(new Vector2(-136f, -4f));
		list.Last().Add(new Vector2(133f, -3f));
		list.Last().Add(new Vector2(134f, -113f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(974, 1109, 352, 176), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(0f, 180.8001f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-151f, -176f));
		list.Last().Add(new Vector2(-154f, -152f));
		list.Last().Add(new Vector2(-149f, -119f));
		list.Last().Add(new Vector2(149f, -119f));
		list.Last().Add(new Vector2(152f, -160f));
		list.Last().Add(new Vector2(146f, -182f));
		list.Last().Add(new Vector2(43f, -236f));
		list.Last().Add(new Vector2(-19f, -235f));
		list.Last().Add(new Vector2(-91f, -217f));
		list.Last().Add(new Vector2(-122f, -201f));
		list.Last().Add(new Vector2(-138f, -179f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1097, 1309, 142, 117), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(-1.600001f, 241.6003f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(8f, -279f));
		list.Last().Add(new Vector2(-3f, -282f));
		list.Last().Add(new Vector2(-7f, -271f));
		list.Last().Add(new Vector2(-44f, -269f));
		list.Last().Add(new Vector2(-43f, -208f));
		list.Last().Add(new Vector2(45f, -206f));
		list.Last().Add(new Vector2(43f, -269f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(993, 1408, 104, 124), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(100.7999f, 184.0001f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-138f, -211f));
		list.Last().Add(new Vector2(-101f, -143f));
		list.Last().Add(new Vector2(-70f, -154f));
		list.Last().Add(new Vector2(-94f, -227f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1198, 1429, 98, 110), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-92.79995f, 177.6001f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(83f, -217f));
		list.Last().Add(new Vector2(67f, -151f));
		list.Last().Add(new Vector2(98f, -147f));
		list.Last().Add(new Vector2(123f, -216f));
		list6.Add(1);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(4f, -217f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(3);
		list4.Add(new Vector2(-91f, -161f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(4);
		list4.Add(new Vector2(83f, -163f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateBedsideTable(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(388, 1378, 154, 245), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 107.1999f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-51f, -209f));
		list.Last().Add(new Vector2(-51f, -192f));
		list.Last().Add(new Vector2(-40f, -190f));
		list.Last().Add(new Vector2(-42f, -4f));
		list.Last().Add(new Vector2(46f, -3f));
		list.Last().Add(new Vector2(44f, -190f));
		list.Last().Add(new Vector2(55f, -191f));
		list.Last().Add(new Vector2(55f, -211f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(419, 1300, 69, 60), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(25.6f, 244.8004f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-20f, -259f));
		list.Last().Add(new Vector2(-46f, -248f));
		list.Last().Add(new Vector2(-36f, -232f));
		list.Last().Add(new Vector2(-11f, -241f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1694, 757, 74, 56), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-33.6f, 238.4003f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(15f, -251f));
		list.Last().Add(new Vector2(8f, -241f));
		list.Last().Add(new Vector2(7f, -228f));
		list.Last().Add(new Vector2(58f, -227f));
		list.Last().Add(new Vector2(58f, -239f));
		list.Last().Add(new Vector2(49f, -252f));
		list3.Add(2);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateUmbilical(PhysicsOutfit outfit)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(104, 1443, 9, 5), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(-6.399999f, 0f);
		list7.Add(MassTypes.ULTRALIGHT_MASS);
		list.Last().Add(new Vector2(-2f, -4f));
		list.Last().Add(new Vector2(12f, -2f));
		list.Last().Add(new Vector2(10f, 1f));
		list.Last().Add(new Vector2(-4f, 2f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(100, 1429, 11, 4), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(-16f, 2.384186E-07f);
		list7.Add(MassTypes.ULTRALIGHT_MASS);
		list.Last().Add(new Vector2(9f, -1f));
		list.Last().Add(new Vector2(11f, 4f));
		list.Last().Add(new Vector2(22f, 2f));
		list.Last().Add(new Vector2(22f, -3f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(97, 1444, 17, 6), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-28.8f, 0f);
		list7.Add(MassTypes.ULTRALIGHT_MASS);
		list.Last().Add(new Vector2(23f, -2f));
		list.Last().Add(new Vector2(23f, 2f));
		list.Last().Add(new Vector2(39f, 2f));
		list.Last().Add(new Vector2(37f, -3f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(103, 1436, 14, 5), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-41.59999f, 0f);
		list7.Add(MassTypes.ULTRALIGHT_MASS);
		list.Last().Add(new Vector2(36f, -2f));
		list.Last().Add(new Vector2(37f, 2f));
		list.Last().Add(new Vector2(50f, 2f));
		list.Last().Add(new Vector2(49f, -6f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(101, 1433, 21, 6), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(-59.19998f, 0f);
		list7.Add(MassTypes.ULTRALIGHT_MASS);
		list.Last().Add(new Vector2(48f, -3f));
		list.Last().Add(new Vector2(50f, 0f));
		list.Last().Add(new Vector2(73f, 3f));
		list.Last().Add(new Vector2(70f, -5f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(99, 1445, 17, 5), default(Vector2), 0.05999999f));
		list2.Last().Last().Origin = new Vector2(-78.39996f, 0f);
		list7.Add(MassTypes.ULTRALIGHT_MASS);
		list.Last().Add(new Vector2(67f, -3f));
		list.Last().Add(new Vector2(70f, 2f));
		list.Last().Add(new Vector2(89f, 3f));
		list.Last().Add(new Vector2(86f, -5f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(11f, 1f));
		list5.Add(PhysicsJointType.FLOPPY_JOINT);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(25f, -1f));
		list5.Add(PhysicsJointType.FLOPPY_JOINT);
		list3.Add(2);
		list3.Add(3);
		list4.Add(new Vector2(43f, 0f));
		list5.Add(PhysicsJointType.FLOPPY_JOINT);
		list3.Add(3);
		list3.Add(4);
		list4.Add(new Vector2(49f, 1f));
		list5.Add(PhysicsJointType.FLOPPY_JOINT);
		list3.Add(4);
		list3.Add(5);
		list4.Add(new Vector2(69f, 1f));
		list5.Add(PhysicsJointType.FLOPPY_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateWall(PhysicsOutfit outfit)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(60, 1650, 158, 159), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 63.99997f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-65f, -128f));
		list.Last().Add(new Vector2(-65f, -3f));
		list.Last().Add(new Vector2(62f, -2f));
		list.Last().Add(new Vector2(60f, -129f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(60, 1650, 157, 157), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(0f, 192.0002f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-64f, -255f));
		list.Last().Add(new Vector2(-64f, -131f));
		list.Last().Add(new Vector2(61f, -132f));
		list.Last().Add(new Vector2(60f, -255f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(61, 1650, 155, 160), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(0f, 318.4006f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-65f, -383f));
		list.Last().Add(new Vector2(-64f, -259f));
		list.Last().Add(new Vector2(60f, -259f));
		list.Last().Add(new Vector2(60f, -383f));
		list3.Add(2);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(61, 1651, 154, 158), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(0f, 448.0011f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-65f, -511f));
		list.Last().Add(new Vector2(-65f, -386f));
		list.Last().Add(new Vector2(62f, -386f));
		list.Last().Add(new Vector2(62f, -511f));
		list3.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(61, 1652, 150, 151), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(3.2f, 577.6003f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-65f, -639f));
		list.Last().Add(new Vector2(-65f, -515f));
		list.Last().Add(new Vector2(61f, -514f));
		list.Last().Add(new Vector2(60f, -640f));
		list3.Add(4);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(61, 1651, 154, 158), default(Vector2), 0.06f));
		list2.Last().Last().Origin = new Vector2(0f, 705f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-65f, -767f));
		list.Last().Add(new Vector2(-65f, -643f));
		list.Last().Add(new Vector2(62f, -642f));
		list.Last().Add(new Vector2(62f, -768f));
		list3.Add(5);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(60, 1650, 158, 159), default(Vector2), -0.99f));
		list2.Last().Last().Origin = new Vector2(0f, 63.99997f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(60, 1650, 157, 157), default(Vector2), -0.98f));
		list2.Last().Last().Origin = new Vector2(0f, 192.0002f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(61, 1650, 155, 160), default(Vector2), -0.97f));
		list2.Last().Last().Origin = new Vector2(0f, 318.4006f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(61, 1651, 154, 158), default(Vector2), -0.96f));
		list2.Last().Last().Origin = new Vector2(0f, 448.0011f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(61, 1652, 150, 151), default(Vector2), -0.95f));
		list2.Last().Last().Origin = new Vector2(3.2f, 577.6003f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(61, 1651, 154, 158), default(Vector2), -0.95f));
		list2.Last().Last().Origin = new Vector2(0f, 705f);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateBedsideTableWithFlower(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(399, 1386, 133, 236), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 100.7999f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-52f, -204f));
		list.Last().Add(new Vector2(-52f, -190f));
		list.Last().Add(new Vector2(-40f, -187f));
		list.Last().Add(new Vector2(-43f, 0f));
		list.Last().Add(new Vector2(45f, -1f));
		list.Last().Add(new Vector2(44f, -189f));
		list.Last().Add(new Vector2(55f, -189f));
		list.Last().Add(new Vector2(55f, -206f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(268, 1675, 158, 160), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(22.4f, 262.4004f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-52f, -253f));
		list.Last().Add(new Vector2(-42f, -209f));
		list.Last().Add(new Vector2(-2f, -208f));
		list.Last().Add(new Vector2(12f, -253f));
		list.Last().Add(new Vector2(37f, -250f));
		list.Last().Add(new Vector2(32f, -270f));
		list.Last().Add(new Vector2(6f, -285f));
		list.Last().Add(new Vector2(13f, -302f));
		list.Last().Add(new Vector2(2f, -321f));
		list.Last().Add(new Vector2(-31f, -323f));
		list.Last().Add(new Vector2(-38f, -306f));
		list.Last().Add(new Vector2(-40f, -296f));
		list.Last().Add(new Vector2(-52f, -285f));
		list.Last().Add(new Vector2(-73f, -283f));
		list.Last().Add(new Vector2(-68f, -262f));
		list.Last().Add(new Vector2(-51f, -257f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(417, 1302, 65, 57), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-30.4f, 219.2003f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(14f, -222f));
		list.Last().Add(new Vector2(23f, -207f));
		list.Last().Add(new Vector2(50f, -215f));
		list.Last().Add(new Vector2(48f, -225f));
		list.Last().Add(new Vector2(38f, -236f));
		list3.Add(2);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(268, 1675, 158, 160), default(Vector2), -1.02f));
		list2.Last().Last().Origin = new Vector2(22.4f, 262.4004f);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateLargeFoodTable(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_102c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1046: Unknown result type (might be due to invalid IL or missing references)
		//IL_1060: Unknown result type (might be due to invalid IL or missing references)
		//IL_107a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1094: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Unknown result type (might be due to invalid IL or missing references)
		//IL_114a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1186: Unknown result type (might be due to invalid IL or missing references)
		//IL_118d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1193: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_120f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1229: Unknown result type (might be due to invalid IL or missing references)
		//IL_1243: Unknown result type (might be due to invalid IL or missing references)
		//IL_125d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1277: Unknown result type (might be due to invalid IL or missing references)
		//IL_1291: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12df: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1313: Unknown result type (might be due to invalid IL or missing references)
		//IL_132d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1366: Unknown result type (might be due to invalid IL or missing references)
		//IL_136d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1373: Unknown result type (might be due to invalid IL or missing references)
		//IL_1399: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1409: Unknown result type (might be due to invalid IL or missing references)
		//IL_143f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1446: Unknown result type (might be due to invalid IL or missing references)
		//IL_144c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1472: Unknown result type (might be due to invalid IL or missing references)
		//IL_1494: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_151b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1522: Unknown result type (might be due to invalid IL or missing references)
		//IL_1528: Unknown result type (might be due to invalid IL or missing references)
		//IL_154e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1570: Unknown result type (might be due to invalid IL or missing references)
		//IL_158a: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15be: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_160c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1626: Unknown result type (might be due to invalid IL or missing references)
		//IL_1640: Unknown result type (might be due to invalid IL or missing references)
		//IL_165a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1738: Unknown result type (might be due to invalid IL or missing references)
		//IL_1763: Unknown result type (might be due to invalid IL or missing references)
		//IL_178e: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1810: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2301, 1200, 390, 216), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(7.999998f, 92.79995f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-181f, -189f));
		list.Last().Add(new Vector2(170f, -189f));
		list.Last().Add(new Vector2(171f, -163f));
		list.Last().Add(new Vector2(125f, -163f));
		list.Last().Add(new Vector2(132f, -2f));
		list.Last().Add(new Vector2(100f, -2f));
		list.Last().Add(new Vector2(107f, -161f));
		list.Last().Add(new Vector2(-116f, -163f));
		list.Last().Add(new Vector2(-111f, -3f));
		list.Last().Add(new Vector2(-146f, -4f));
		list.Last().Add(new Vector2(-137f, -161f));
		list.Last().Add(new Vector2(-179f, -163f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2820, 1593, 216, 172), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(238.4003f, 67.19997f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-329f, -102f));
		list.Last().Add(new Vector2(-324f, -91f));
		list.Last().Add(new Vector2(-230f, -97f));
		list.Last().Add(new Vector2(-222f, -20f));
		list.Last().Add(new Vector2(-223f, -3f));
		list.Last().Add(new Vector2(-148f, -2f));
		list.Last().Add(new Vector2(-158f, -21f));
		list.Last().Add(new Vector2(-169f, -21f));
		list.Last().Add(new Vector2(-174f, -83f));
		list.Last().Add(new Vector2(-180f, -118f));
		list.Last().Add(new Vector2(-199f, -133f));
		list.Last().Add(new Vector2(-240f, -138f));
		list.Last().Add(new Vector2(-318f, -126f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2647, 1583, 163, 184), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(270.4005f, 172.8001f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-332f, -99f));
		list.Last().Add(new Vector2(-216f, -134f));
		list.Last().Add(new Vector2(-214f, -163f));
		list.Last().Add(new Vector2(-226f, -204f));
		list.Last().Add(new Vector2(-253f, -243f));
		list.Last().Add(new Vector2(-315f, -250f));
		list.Last().Add(new Vector2(-323f, -211f));
		list.Last().Add(new Vector2(-328f, -181f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2801, 1426, 203, 141), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(219.2003f, 209.6002f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-300f, -218f));
		list.Last().Add(new Vector2(-284f, -232f));
		list.Last().Add(new Vector2(-270f, -230f));
		list.Last().Add(new Vector2(-237f, -205f));
		list.Last().Add(new Vector2(-189f, -246f));
		list.Last().Add(new Vector2(-155f, -249f));
		list.Last().Add(new Vector2(-139f, -227f));
		list.Last().Add(new Vector2(-162f, -210f));
		list.Last().Add(new Vector2(-165f, -200f));
		list.Last().Add(new Vector2(-192f, -186f));
		list.Last().Add(new Vector2(-216f, -164f));
		list.Last().Add(new Vector2(-243f, -167f));
		list.Last().Add(new Vector2(-291f, -186f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2653, 1437, 132, 148), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(272.0005f, 296.0005f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-318f, -298f));
		list.Last().Add(new Vector2(-313f, -282f));
		list.Last().Add(new Vector2(-312f, -242f));
		list.Last().Add(new Vector2(-266f, -238f));
		list.Last().Add(new Vector2(-253f, -255f));
		list.Last().Add(new Vector2(-236f, -257f));
		list.Last().Add(new Vector2(-238f, -278f));
		list.Last().Add(new Vector2(-223f, -280f));
		list.Last().Add(new Vector2(-236f, -296f));
		list.Last().Add(new Vector2(-233f, -316f));
		list.Last().Add(new Vector2(-244f, -339f));
		list.Last().Add(new Vector2(-300f, -343f));
		list.Last().Add(new Vector2(-313f, -333f));
		list.Last().Add(new Vector2(-317f, -303f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2075, 1077, 165, 266), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(294.4005f, 116.7999f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-342f, -99f));
		list.Last().Add(new Vector2(-336f, -90f));
		list.Last().Add(new Vector2(-236f, -87f));
		list.Last().Add(new Vector2(-236f, -71f));
		list.Last().Add(new Vector2(-243f, -71f));
		list.Last().Add(new Vector2(-231f, -3f));
		list.Last().Add(new Vector2(-263f, -4f));
		list.Last().Add(new Vector2(-257f, -73f));
		list.Last().Add(new Vector2(-333f, -73f));
		list.Last().Add(new Vector2(-328f, -3f));
		list.Last().Add(new Vector2(-357f, -2f));
		list.Last().Add(new Vector2(-352f, -72f));
		list.Last().Add(new Vector2(-357f, -74f));
		list.Last().Add(new Vector2(-358f, -232f));
		list.Last().Add(new Vector2(-338f, -229f));
		list6.Add(2);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3058, 1584, 197, 172), default(Vector2), 0.05999999f));
		list2.Last().Last().Origin = new Vector2(-217.6003f, 76.79996f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(141f, -20f));
		list.Last().Add(new Vector2(140f, -15f));
		list.Last().Add(new Vector2(206f, -12f));
		list.Last().Add(new Vector2(205f, -101f));
		list.Last().Add(new Vector2(216f, -107f));
		list.Last().Add(new Vector2(292f, -103f));
		list.Last().Add(new Vector2(300f, -111f));
		list.Last().Add(new Vector2(272f, -143f));
		list.Last().Add(new Vector2(180f, -132f));
		list.Last().Add(new Vector2(166f, -114f));
		list.Last().Add(new Vector2(159f, -31f));
		list6.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3263, 1587, 132, 176), default(Vector2), 0.06999999f));
		list2.Last().Last().Origin = new Vector2(-260.8004f, 182.4001f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(218f, -137f));
		list.Last().Add(new Vector2(258f, -129f));
		list.Last().Add(new Vector2(302f, -109f));
		list.Last().Add(new Vector2(282f, -167f));
		list.Last().Add(new Vector2(298f, -228f));
		list.Last().Add(new Vector2(286f, -256f));
		list.Last().Add(new Vector2(262f, -240f));
		list.Last().Add(new Vector2(238f, -244f));
		list.Last().Add(new Vector2(217f, -221f));
		list.Last().Add(new Vector2(233f, -178f));
		list6.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3028, 1420, 194, 140), default(Vector2), 0.07999999f));
		list2.Last().Last().Origin = new Vector2(-201.6002f, 209.6002f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(250f, -237f));
		list.Last().Add(new Vector2(222f, -196f));
		list.Last().Add(new Vector2(173f, -235f));
		list.Last().Add(new Vector2(165f, -250f));
		list.Last().Add(new Vector2(139f, -253f));
		list.Last().Add(new Vector2(129f, -232f));
		list.Last().Add(new Vector2(136f, -217f));
		list.Last().Add(new Vector2(149f, -213f));
		list.Last().Add(new Vector2(233f, -159f));
		list.Last().Add(new Vector2(278f, -222f));
		list.Last().Add(new Vector2(275f, -241f));
		list6.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3230, 1426, 153, 150), default(Vector2), 0.05999999f));
		list2.Last().Last().Origin = new Vector2(-268.8004f, 296.0005f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(242f, -270f));
		list.Last().Add(new Vector2(241f, -237f));
		list.Last().Add(new Vector2(282f, -239f));
		list.Last().Add(new Vector2(282f, -263f));
		list.Last().Add(new Vector2(307f, -242f));
		list.Last().Add(new Vector2(330f, -251f));
		list.Last().Add(new Vector2(314f, -275f));
		list.Last().Add(new Vector2(300f, -302f));
		list.Last().Add(new Vector2(302f, -328f));
		list.Last().Add(new Vector2(264f, -353f));
		list.Last().Add(new Vector2(221f, -349f));
		list.Last().Add(new Vector2(216f, -335f));
		list.Last().Add(new Vector2(222f, -316f));
		list.Last().Add(new Vector2(206f, -287f));
		list.Last().Add(new Vector2(218f, -283f));
		list.Last().Add(new Vector2(215f, -265f));
		list6.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2718, 1106, 161, 257), default(Vector2), 0.06999999f));
		list2.Last().Last().Origin = new Vector2(-283.2005f, 113.5999f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(216f, -100f));
		list.Last().Add(new Vector2(217f, -73f));
		list.Last().Add(new Vector2(223f, -72f));
		list.Last().Add(new Vector2(218f, -2f));
		list.Last().Add(new Vector2(248f, -1f));
		list.Last().Add(new Vector2(242f, -70f));
		list.Last().Add(new Vector2(316f, -72f));
		list.Last().Add(new Vector2(311f, -3f));
		list.Last().Add(new Vector2(343f, -3f));
		list.Last().Add(new Vector2(333f, -70f));
		list.Last().Add(new Vector2(333f, -96f));
		list.Last().Add(new Vector2(341f, -229f));
		list.Last().Add(new Vector2(319f, -229f));
		list.Last().Add(new Vector2(320f, -101f));
		list6.Add(4);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2408, 1137, 182, 43), default(Vector2), 0.07999999f));
		list2.Last().Last().Origin = new Vector2(68.79997f, 198.4002f);
		list7.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-144f, -210f));
		list.Last().Add(new Vector2(-127f, -194f));
		list.Last().Add(new Vector2(-1f, -194f));
		list.Last().Add(new Vector2(11f, -208f));
		list6.Add(5);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2660, 1808, 113, 53), default(Vector2), 0.08999999f));
		list2.Last().Last().Origin = new Vector2(99.19994f, 217.6003f);
		list7.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-131f, -226f));
		list.Last().Add(new Vector2(-134f, -211f));
		list.Last().Add(new Vector2(-61f, -214f));
		list.Last().Add(new Vector2(-65f, -228f));
		list6.Add(6);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3154, 1800, 140, 79), default(Vector2), 0.11f));
		list2.Last().Last().Origin = new Vector2(-76.79996f, 214.4002f);
		list7.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(38f, -217f));
		list.Last().Add(new Vector2(61f, -193f));
		list.Last().Add(new Vector2(111f, -194f));
		list.Last().Add(new Vector2(128f, -220f));
		list.Last().Add(new Vector2(113f, -221f));
		list.Last().Add(new Vector2(102f, -233f));
		list.Last().Add(new Vector2(87f, -227f));
		list.Last().Add(new Vector2(71f, -234f));
		list.Last().Add(new Vector2(56f, -232f));
		list.Last().Add(new Vector2(44f, -223f));
		list6.Add(8);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(-282f, -121f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(2);
		list3.Add(3);
		list4.Add(new Vector2(-282f, -210f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(2);
		list3.Add(4);
		list4.Add(new Vector2(-284f, -236f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(7);
		list3.Add(6);
		list4.Add(new Vector2(263f, -136f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(8);
		list3.Add(7);
		list4.Add(new Vector2(262f, -224f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(7);
		list3.Add(9);
		list4.Add(new Vector2(262f, -231f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateSmallFoodTable(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc7: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2177, 1489, 307, 228), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(4.799998f, 94.39995f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-141f, -190f));
		list.Last().Add(new Vector2(-141f, -164f));
		list.Last().Add(new Vector2(-100f, -163f));
		list.Last().Add(new Vector2(-107f, -4f));
		list.Last().Add(new Vector2(-70f, -3f));
		list.Last().Add(new Vector2(-77f, -162f));
		list.Last().Add(new Vector2(66f, -163f));
		list.Last().Add(new Vector2(61f, -4f));
		list.Last().Add(new Vector2(95f, -3f));
		list.Last().Add(new Vector2(88f, -163f));
		list.Last().Add(new Vector2(133f, -163f));
		list.Last().Add(new Vector2(131f, -189f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2814, 1583, 221, 178), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(206.4002f, 87.99995f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-282f, -141f));
		list.Last().Add(new Vector2(-296f, -118f));
		list.Last().Add(new Vector2(-288f, -106f));
		list.Last().Add(new Vector2(-194f, -110f));
		list.Last().Add(new Vector2(-188f, -34f));
		list.Last().Add(new Vector2(-190f, -17f));
		list.Last().Add(new Vector2(-114f, -15f));
		list.Last().Add(new Vector2(-120f, -35f));
		list.Last().Add(new Vector2(-134f, -35f));
		list.Last().Add(new Vector2(-141f, -112f));
		list.Last().Add(new Vector2(-144f, -135f));
		list.Last().Add(new Vector2(-165f, -145f));
		list.Last().Add(new Vector2(-211f, -150f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2643, 1582, 168, 193), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(238.4003f, 184.0001f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-283f, -265f));
		list.Last().Add(new Vector2(-296f, -201f));
		list.Last().Add(new Vector2(-298f, -112f));
		list.Last().Add(new Vector2(-229f, -132f));
		list.Last().Add(new Vector2(-184f, -149f));
		list.Last().Add(new Vector2(-180f, -176f));
		list.Last().Add(new Vector2(-194f, -218f));
		list.Last().Add(new Vector2(-221f, -258f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2799, 1426, 212, 144), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(187.2001f, 220.8003f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-255f, -245f));
		list.Last().Add(new Vector2(-270f, -230f));
		list.Last().Add(new Vector2(-262f, -199f));
		list.Last().Add(new Vector2(-218f, -175f));
		list.Last().Add(new Vector2(-191f, -177f));
		list.Last().Add(new Vector2(-135f, -218f));
		list.Last().Add(new Vector2(-110f, -243f));
		list.Last().Add(new Vector2(-129f, -263f));
		list.Last().Add(new Vector2(-157f, -257f));
		list.Last().Add(new Vector2(-170f, -251f));
		list.Last().Add(new Vector2(-207f, -214f));
		list.Last().Add(new Vector2(-239f, -242f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2651, 1440, 135, 139), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(238.4003f, 315.2006f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-283f, -316f));
		list.Last().Add(new Vector2(-278f, -260f));
		list.Last().Add(new Vector2(-233f, -256f));
		list.Last().Add(new Vector2(-219f, -271f));
		list.Last().Add(new Vector2(-207f, -273f));
		list.Last().Add(new Vector2(-202f, -294f));
		list.Last().Add(new Vector2(-189f, -298f));
		list.Last().Add(new Vector2(-201f, -312f));
		list.Last().Add(new Vector2(-199f, -338f));
		list.Last().Add(new Vector2(-212f, -356f));
		list.Last().Add(new Vector2(-263f, -363f));
		list.Last().Add(new Vector2(-278f, -354f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2074, 1080, 169, 265), default(Vector2), 0.05999999f));
		list2.Last().Last().Origin = new Vector2(262.4004f, 115.1999f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-328f, -230f));
		list.Last().Add(new Vector2(-325f, -74f));
		list.Last().Add(new Vector2(-321f, -74f));
		list.Last().Add(new Vector2(-326f, -4f));
		list.Last().Add(new Vector2(-295f, -3f));
		list.Last().Add(new Vector2(-301f, -72f));
		list.Last().Add(new Vector2(-226f, -75f));
		list.Last().Add(new Vector2(-231f, -4f));
		list.Last().Add(new Vector2(-200f, -5f));
		list.Last().Add(new Vector2(-209f, -74f));
		list.Last().Add(new Vector2(-206f, -77f));
		list.Last().Add(new Vector2(-207f, -100f));
		list.Last().Add(new Vector2(-311f, -101f));
		list.Last().Add(new Vector2(-306f, -231f));
		list6.Add(2);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2414, 1136, 179, 45), default(Vector2), 0.06999999f));
		list2.Last().Last().Origin = new Vector2(46.39999f, 201.6002f);
		list7.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-124f, -211f));
		list.Last().Add(new Vector2(-109f, -194f));
		list.Last().Add(new Vector2(17f, -194f));
		list.Last().Add(new Vector2(30f, -214f));
		list6.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2667, 1808, 101, 49), default(Vector2), 0.07999999f));
		list2.Last().Last().Origin = new Vector2(71.99997f, 224.0003f);
		list7.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-107f, -233f));
		list.Last().Add(new Vector2(-108f, -216f));
		list.Last().Add(new Vector2(-36f, -217f));
		list.Last().Add(new Vector2(-38f, -231f));
		list6.Add(4);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(-240f, -130f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(2);
		list3.Add(3);
		list4.Add(new Vector2(-252f, -220f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(2);
		list3.Add(4);
		list4.Add(new Vector2(-256f, -252f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateEmptyBed(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1364, 1066, 318, 430), default(Vector2), SceneRenderer.GetRand(-5f, -5.5f)));
		list2.Last().Last().Origin = new Vector2(0f, 195.2002f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(134f, -113f));
		list.Last().Add(new Vector2(-136f, -111f));
		list.Last().Add(new Vector2(-136f, -3f));
		list.Last().Add(new Vector2(135f, -3f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(605, 1761, 375, 109), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(0f, 142.4f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-169f, -166f));
		list.Last().Add(new Vector2(-165f, -115f));
		list.Last().Add(new Vector2(162f, -116f));
		list.Last().Add(new Vector2(165f, -152f));
		list.Last().Add(new Vector2(161f, -181f));
		list.Last().Add(new Vector2(-164f, -179f));
		list3.Add(1);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateFoodTray(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1952, 1463, 161, 264), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(-3.199999f, 115.1999f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-53f, -228f));
		list.Last().Add(new Vector2(-55f, -209f));
		list.Last().Add(new Vector2(-48f, -209f));
		list.Last().Add(new Vector2(-48f, -104f));
		list.Last().Add(new Vector2(-53f, -106f));
		list.Last().Add(new Vector2(-54f, -28f));
		list.Last().Add(new Vector2(-49f, -9f));
		list.Last().Add(new Vector2(-39f, -2f));
		list.Last().Add(new Vector2(-27f, -6f));
		list.Last().Add(new Vector2(-20f, -23f));
		list.Last().Add(new Vector2(-14f, -28f));
		list.Last().Add(new Vector2(27f, -26f));
		list.Last().Add(new Vector2(28f, -12f));
		list.Last().Add(new Vector2(36f, -4f));
		list.Last().Add(new Vector2(43f, -1f));
		list.Last().Add(new Vector2(57f, -7f));
		list.Last().Add(new Vector2(59f, -28f));
		list.Last().Add(new Vector2(58f, -104f));
		list.Last().Add(new Vector2(53f, -103f));
		list.Last().Add(new Vector2(52f, -209f));
		list.Last().Add(new Vector2(58f, -211f));
		list.Last().Add(new Vector2(60f, -227f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(442, 1757, 164, 50), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(0f, 240.0003f);
		list4.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-66f, -242f));
		list.Last().Add(new Vector2(-52f, -234f));
		list.Last().Add(new Vector2(54f, -236f));
		list.Last().Add(new Vector2(66f, -243f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(445, 1682, 69, 62), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(33.6f, 262.4004f);
		list4.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-55f, -258f));
		list.Last().Add(new Vector2(-48f, -246f));
		list.Last().Add(new Vector2(-37f, -249f));
		list.Last().Add(new Vector2(-23f, -247f));
		list.Last().Add(new Vector2(-19f, -263f));
		list.Last().Add(new Vector2(-23f, -284f));
		list.Last().Add(new Vector2(-35f, -272f));
		list.Last().Add(new Vector2(-43f, -278f));
		list3.Add(2);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(528, 1685, 65, 64), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-25.6f, 257.6004f);
		list4.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(8f, -274f));
		list.Last().Add(new Vector2(12f, -246f));
		list.Last().Add(new Vector2(38f, -246f));
		list.Last().Add(new Vector2(41f, -269f));
		list3.Add(3);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateBypass(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1128, 1853, 338, 221), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(6.399998f, 91.19995f);
		list7.Add(MassTypes.ULTRAHEAVY_MASS);
		list.Last().Add(new Vector2(-153f, -19f));
		list.Last().Add(new Vector2(-143f, -2f));
		list.Last().Add(new Vector2(-129f, -3f));
		list.Last().Add(new Vector2(-122f, -18f));
		list.Last().Add(new Vector2(110f, -16f));
		list.Last().Add(new Vector2(117f, -3f));
		list.Last().Add(new Vector2(132f, -2f));
		list.Last().Add(new Vector2(137f, -17f));
		list.Last().Add(new Vector2(141f, -16f));
		list.Last().Add(new Vector2(141f, -186f));
		list.Last().Add(new Vector2(-154f, -185f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1121, 1679, 120, 151), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(99.19994f, 214.4002f);
		list7.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-136f, -270f));
		list.Last().Add(new Vector2(-135f, -157f));
		list.Last().Add(new Vector2(-67f, -156f));
		list.Last().Add(new Vector2(-68f, -272f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1243, 1695, 102, 138), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(14.4f, 204.8002f);
		list7.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(-49f, -241f));
		list.Last().Add(new Vector2(-47f, -157f));
		list.Last().Add(new Vector2(16f, -155f));
		list.Last().Add(new Vector2(17f, -240f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1360, 1680, 116, 159), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-81.59996f, 208.0002f);
		list7.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(45f, -257f));
		list.Last().Add(new Vector2(44f, -155f));
		list.Last().Add(new Vector2(116f, -155f));
		list.Last().Add(new Vector2(113f, -258f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1121, 1679, 120, 151), default(Vector2), -0.98f));
		list2.Last().Last().Origin = new Vector2(99.19994f, 214.4002f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1243, 1695, 102, 138), default(Vector2), -0.97f));
		list2.Last().Last().Origin = new Vector2(14.4f, 204.8002f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1360, 1680, 116, 159), default(Vector2), -0.96f));
		list2.Last().Last().Origin = new Vector2(-81.59996f, 208.0002f);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(-100f, -169f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(0);
		list3.Add(2);
		list4.Add(new Vector2(-18f, -171f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(0);
		list3.Add(3);
		list4.Add(new Vector2(81f, -169f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateXRay(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1904, 2430, 345, 308), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(11.2f, 129.5999f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-148f, -263f));
		list.Last().Add(new Vector2(-147f, -44f));
		list.Last().Add(new Vector2(-139f, -42f));
		list.Last().Add(new Vector2(-137f, -2f));
		list.Last().Add(new Vector2(-118f, -2f));
		list.Last().Add(new Vector2(-116f, -43f));
		list.Last().Add(new Vector2(103f, -42f));
		list.Last().Add(new Vector2(102f, -4f));
		list.Last().Add(new Vector2(124f, -4f));
		list.Last().Add(new Vector2(124f, -42f));
		list.Last().Add(new Vector2(133f, -43f));
		list.Last().Add(new Vector2(133f, -264f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1892, 2271, 143, 151), default(Vector2), 0f));
		list2.Last().Last().Origin = new Vector2(17.6f, 316.8006f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-52f, -367f));
		list.Last().Add(new Vector2(-48f, -330f));
		list.Last().Add(new Vector2(-47f, -282f));
		list.Last().Add(new Vector2(-28f, -282f));
		list.Last().Add(new Vector2(-23f, -260f));
		list.Last().Add(new Vector2(14f, -256f));
		list.Last().Add(new Vector2(18f, -279f));
		list.Last().Add(new Vector2(37f, -280f));
		list.Last().Add(new Vector2(38f, -344f));
		list.Last().Add(new Vector2(48f, -374f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2032, 2330, 95, 82), default(Vector2), 0f));
		list2.Last().Last().Origin = new Vector2(47.99999f, 24f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-20f, -47f));
		list.Last().Add(new Vector2(-20f, -4f));
		list.Last().Add(new Vector2(-72f, -4f));
		list.Last().Add(new Vector2(-73f, -25f));
		list.Last().Add(new Vector2(-37f, -23f));
		list.Last().Add(new Vector2(-41f, -54f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2141, 2323, 94, 90), default(Vector2), 0f));
		list2.Last().Last().Origin = new Vector2(-46.39999f, 25.6f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(33f, -49f));
		list.Last().Add(new Vector2(18f, -48f));
		list.Last().Add(new Vector2(17f, -2f));
		list.Last().Add(new Vector2(71f, -3f));
		list.Last().Add(new Vector2(71f, -24f));
		list.Last().Add(new Vector2(35f, -22f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1904, 2430, 345, 308), default(Vector2), -0.99f));
		list2.Last().Last().Origin = new Vector2(11.2f, 129.5999f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1892, 2271, 143, 151), default(Vector2), -1f));
		list2.Last().Last().Origin = new Vector2(17.6f, 316.8006f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2032, 2330, 95, 82), default(Vector2), -1f));
		list2.Last().Last().Origin = new Vector2(47.99999f, 24f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2141, 2323, 94, 90), default(Vector2), -1f));
		list2.Last().Last().Origin = new Vector2(-46.39999f, 25.6f);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(-4f, -248f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(0);
		list3.Add(2);
		list4.Add(new Vector2(-31f, -57f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		list3.Add(0);
		list3.Add(3);
		list4.Add(new Vector2(24f, -57f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateSurgeryLight(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(225, 2733, 292, 461), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 209.6002f);
		list7.Add(MassTypes.ULTRAHEAVY_MASS);
		list.Last().Add(new Vector2(-106f, -18f));
		list.Last().Add(new Vector2(-105f, -1f));
		list.Last().Add(new Vector2(89f, -2f));
		list.Last().Add(new Vector2(88f, -24f));
		list.Last().Add(new Vector2(10f, -41f));
		list.Last().Add(new Vector2(-1f, -292f));
		list.Last().Add(new Vector2(39f, -351f));
		list.Last().Add(new Vector2(94f, -352f));
		list.Last().Add(new Vector2(119f, -391f));
		list.Last().Add(new Vector2(75f, -391f));
		list.Last().Add(new Vector2(29f, -379f));
		list.Last().Add(new Vector2(-26f, -298f));
		list.Last().Add(new Vector2(-27f, -40f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(512, 2716, 422, 415), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(-232.0003f, 302.4006f);
		list7.Add(MassTypes.LIGHT_MASS);
		list.Last().Add(new Vector2(99f, -458f));
		list.Last().Add(new Vector2(51f, -390f));
		list.Last().Add(new Vector2(67f, -311f));
		list.Last().Add(new Vector2(96f, -283f));
		list.Last().Add(new Vector2(106f, -303f));
		list.Last().Add(new Vector2(117f, -296f));
		list.Last().Add(new Vector2(214f, -438f));
		list.Last().Add(new Vector2(196f, -452f));
		list.Last().Add(new Vector2(200f, -466f));
		list.Last().Add(new Vector2(162f, -477f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(225, 2733, 292, 461), default(Vector2), -0.99f));
		list2.Last().Last().Origin = new Vector2(0f, 209.6002f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(512, 2716, 422, 415), default(Vector2), -0.98f));
		list2.Last().Last().Origin = new Vector2(-232.0003f, 302.4006f);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(93f, -377f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateSurgeryDoctor(PhysicsOutfit outfit)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3133, 2248, 118, 195), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 73.59997f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-41f, -30f));
		list.Last().Add(new Vector2(-42f, -3f));
		list.Last().Add(new Vector2(33f, -2f));
		list.Last().Add(new Vector2(32f, -151f));
		list.Last().Add(new Vector2(-5f, -143f));
		list.Last().Add(new Vector2(2f, -30f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2896, 2210, 130, 229), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(-11.2f, 233.6003f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-19f, -329f));
		list.Last().Add(new Vector2(-34f, -136f));
		list.Last().Add(new Vector2(60f, -137f));
		list.Last().Add(new Vector2(41f, -328f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2822, 2228, 69, 190), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-16f, 244.8004f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(0f, -324f));
		list.Last().Add(new Vector2(-3f, -201f));
		list.Last().Add(new Vector2(0f, -184f));
		list.Last().Add(new Vector2(21f, -166f));
		list.Last().Add(new Vector2(37f, -188f));
		list.Last().Add(new Vector2(26f, -317f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(690, 15, 132, 159), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(7.999999f, 377.6009f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-46f, -412f));
		list.Last().Add(new Vector2(-48f, -390f));
		list.Last().Add(new Vector2(-41f, -373f));
		list.Last().Add(new Vector2(-42f, -349f));
		list.Last().Add(new Vector2(-27f, -331f));
		list.Last().Add(new Vector2(-12f, -342f));
		list.Last().Add(new Vector2(-2f, -317f));
		list.Last().Add(new Vector2(33f, -325f));
		list.Last().Add(new Vector2(26f, -350f));
		list.Last().Add(new Vector2(28f, -365f));
		list.Last().Add(new Vector2(24f, -406f));
		list.Last().Add(new Vector2(30f, -407f));
		list.Last().Add(new Vector2(24f, -426f));
		list.Last().Add(new Vector2(10f, -433f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(3133, 2248, 118, 195), default(Vector2), -1.01f));
		list2.Last().Last().Origin = new Vector2(0f, 73.59997f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2896, 2210, 130, 229), default(Vector2), -1.02f));
		list2.Last().Last().Origin = new Vector2(-11.2f, 233.6003f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2822, 2228, 69, 190), default(Vector2), -1.03f));
		list2.Last().Last().Origin = new Vector2(-16f, 244.8004f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(690, 15, 132, 159), default(Vector2), -1.01f));
		list2.Last().Last().Origin = new Vector2(7.999999f, 377.6009f);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(14f, -153f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(16f, -305f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(3);
		list4.Add(new Vector2(13f, -313f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateSurgeryPatient(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(862, 2427, 476, 225), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(25.6f, 87.99995f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-219f, -61f));
		list.Last().Add(new Vector2(-219f, -37f));
		list.Last().Add(new Vector2(-194f, -34f));
		list.Last().Add(new Vector2(-191f, -14f));
		list.Last().Add(new Vector2(-180f, -4f));
		list.Last().Add(new Vector2(-168f, -3f));
		list.Last().Add(new Vector2(-154f, -15f));
		list.Last().Add(new Vector2(-156f, -37f));
		list.Last().Add(new Vector2(113f, -34f));
		list.Last().Add(new Vector2(117f, -17f));
		list.Last().Add(new Vector2(127f, -4f));
		list.Last().Add(new Vector2(142f, -4f));
		list.Last().Add(new Vector2(152f, -19f));
		list.Last().Add(new Vector2(151f, -37f));
		list.Last().Add(new Vector2(185f, -37f));
		list.Last().Add(new Vector2(185f, -63f));
		list.Last().Add(new Vector2(160f, -64f));
		list.Last().Add(new Vector2(159f, -155f));
		list.Last().Add(new Vector2(182f, -156f));
		list.Last().Add(new Vector2(184f, -182f));
		list.Last().Add(new Vector2(-218f, -181f));
		list.Last().Add(new Vector2(-219f, -157f));
		list.Last().Add(new Vector2(-206f, -157f));
		list.Last().Add(new Vector2(-206f, -62f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(842, 2232, 523, 188), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(22.4f, 246.4004f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-244f, -186f));
		list.Last().Add(new Vector2(113f, -195f));
		list.Last().Add(new Vector2(214f, -189f));
		list.Last().Add(new Vector2(213f, -278f));
		list.Last().Add(new Vector2(173f, -274f));
		list.Last().Add(new Vector2(150f, -291f));
		list.Last().Add(new Vector2(146f, -275f));
		list.Last().Add(new Vector2(112f, -273f));
		list.Last().Add(new Vector2(117f, -240f));
		list.Last().Add(new Vector2(107f, -240f));
		list.Last().Add(new Vector2(95f, -260f));
		list.Last().Add(new Vector2(71f, -259f));
		list.Last().Add(new Vector2(62f, -280f));
		list.Last().Add(new Vector2(63f, -292f));
		list.Last().Add(new Vector2(6f, -312f));
		list.Last().Add(new Vector2(-69f, -303f));
		list.Last().Add(new Vector2(-71f, -299f));
		list.Last().Add(new Vector2(-66f, -281f));
		list.Last().Add(new Vector2(-70f, -267f));
		list.Last().Add(new Vector2(-83f, -266f));
		list.Last().Add(new Vector2(-103f, -241f));
		list.Last().Add(new Vector2(-175f, -228f));
		list.Last().Add(new Vector2(-209f, -268f));
		list.Last().Add(new Vector2(-248f, -256f));
		list3.Add(1);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateArmless(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(248, 3570, 182, 158), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 62.39998f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-73f, -122f));
		list.Last().Add(new Vector2(-72f, -77f));
		list.Last().Add(new Vector2(-59f, -74f));
		list.Last().Add(new Vector2(-59f, -23f));
		list.Last().Add(new Vector2(-38f, -2f));
		list.Last().Add(new Vector2(45f, -1f));
		list.Last().Add(new Vector2(62f, -18f));
		list.Last().Add(new Vector2(61f, -75f));
		list.Last().Add(new Vector2(71f, -75f));
		list.Last().Add(new Vector2(71f, -122f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(475, 3559, 136, 186), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(-119.9999f, 68.79997f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(81f, -119f));
		list.Last().Add(new Vector2(91f, -5f));
		list.Last().Add(new Vector2(162f, -2f));
		list.Last().Add(new Vector2(169f, -30f));
		list.Last().Add(new Vector2(121f, -30f));
		list.Last().Add(new Vector2(125f, -136f));
		list.Last().Add(new Vector2(111f, -144f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(313, 3358, 218, 201), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-52.79998f, 185.6001f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-22f, -264f));
		list.Last().Add(new Vector2(-33f, -156f));
		list.Last().Add(new Vector2(-2f, -126f));
		list.Last().Add(new Vector2(72f, -128f));
		list.Last().Add(new Vector2(73f, -113f));
		list.Last().Add(new Vector2(92f, -104f));
		list.Last().Add(new Vector2(139f, -129f));
		list.Last().Add(new Vector2(135f, -144f));
		list.Last().Add(new Vector2(107f, -152f));
		list.Last().Add(new Vector2(61f, -202f));
		list.Last().Add(new Vector2(49f, -259f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(300, 3205, 150, 153), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(-9.600001f, 313.6006f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-52f, -339f));
		list.Last().Add(new Vector2(-48f, -286f));
		list.Last().Add(new Vector2(-23f, -310f));
		list.Last().Add(new Vector2(-12f, -316f));
		list.Last().Add(new Vector2(-17f, -256f));
		list.Last().Add(new Vector2(27f, -253f));
		list.Last().Add(new Vector2(28f, -289f));
		list.Last().Add(new Vector2(56f, -293f));
		list.Last().Add(new Vector2(60f, -356f));
		list.Last().Add(new Vector2(14f, -371f));
		list.Last().Add(new Vector2(-21f, -363f));
		list.Last().Add(new Vector2(-30f, -347f));
		list6.Add(1);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(103f, -130f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(3);
		list3.Add(2);
		list4.Add(new Vector2(7f, -246f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateLimbTable(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(654, 3494, 420, 232), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 84.79996f);
		list4.Add(MassTypes.ULTRAHEAVY_MASS);
		list.Last().Add(new Vector2(-186f, -181f));
		list.Last().Add(new Vector2(-187f, -147f));
		list.Last().Add(new Vector2(-176f, -146f));
		list.Last().Add(new Vector2(-176f, -2f));
		list.Last().Add(new Vector2(174f, -2f));
		list.Last().Add(new Vector2(174f, -146f));
		list.Last().Add(new Vector2(185f, -145f));
		list.Last().Add(new Vector2(185f, -182f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(670, 3192, 168, 119), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(121.5999f, 224.0003f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-174f, -228f));
		list.Last().Add(new Vector2(-179f, -191f));
		list.Last().Add(new Vector2(-70f, -186f));
		list.Last().Add(new Vector2(-72f, -265f));
		list.Last().Add(new Vector2(-85f, -267f));
		list.Last().Add(new Vector2(-90f, -228f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(694, 3372, 170, 110), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(3.200002f, 217.6003f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-63f, -217f));
		list.Last().Add(new Vector2(-42f, -185f));
		list.Last().Add(new Vector2(6f, -214f));
		list.Last().Add(new Vector2(38f, -206f));
		list.Last().Add(new Vector2(52f, -238f));
		list.Last().Add(new Vector2(7f, -258f));
		list.Last().Add(new Vector2(-4f, -233f));
		list3.Add(2);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(855, 3166, 173, 150), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-97.59995f, 241.6003f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(48f, -264f));
		list.Last().Add(new Vector2(72f, -209f));
		list.Last().Add(new Vector2(72f, -185f));
		list.Last().Add(new Vector2(148f, -189f));
		list.Last().Add(new Vector2(144f, -223f));
		list.Last().Add(new Vector2(114f, -211f));
		list.Last().Add(new Vector2(87f, -290f));
		list3.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(894, 3335, 142, 158), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(-152f, 249.6004f);
		list4.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(102f, -276f));
		list.Last().Add(new Vector2(128f, -263f));
		list.Last().Add(new Vector2(168f, -187f));
		list.Last().Add(new Vector2(182f, -188f));
		list.Last().Add(new Vector2(201f, -203f));
		list.Last().Add(new Vector2(153f, -268f));
		list.Last().Add(new Vector2(160f, -294f));
		list.Last().Add(new Vector2(127f, -312f));
		list3.Add(4);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(670, 3192, 168, 119), default(Vector2), -0.98f));
		list2.Last().Last().Origin = new Vector2(121.5999f, 224.0003f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(694, 3372, 170, 110), default(Vector2), -0.97f));
		list2.Last().Last().Origin = new Vector2(3.200002f, 217.6003f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(855, 3166, 173, 150), default(Vector2), -0.96f));
		list2.Last().Last().Origin = new Vector2(-97.59995f, 241.6003f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(894, 3335, 142, 158), default(Vector2), -0.95f));
		list2.Last().Last().Origin = new Vector2(-152f, 249.6004f);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreatePhysiotherapyBars(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1111, 3094, 413, 237), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 100.7999f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-154f, -35f));
		list.Last().Add(new Vector2(-185f, -4f));
		list.Last().Add(new Vector2(187f, -1f));
		list.Last().Add(new Vector2(158f, -34f));
		list.Last().Add(new Vector2(157f, -153f));
		list.Last().Add(new Vector2(123f, -186f));
		list.Last().Add(new Vector2(105f, -187f));
		list.Last().Add(new Vector2(106f, -195f));
		list.Last().Add(new Vector2(67f, -193f));
		list.Last().Add(new Vector2(69f, -187f));
		list.Last().Add(new Vector2(-69f, -188f));
		list.Last().Add(new Vector2(-69f, -195f));
		list.Last().Add(new Vector2(-106f, -194f));
		list.Last().Add(new Vector2(-107f, -184f));
		list.Last().Add(new Vector2(-117f, -186f));
		list.Last().Add(new Vector2(-154f, -148f));
		list3.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateWheelchair(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1128, 3373, 254, 280), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 121.5999f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-102f, -242f));
		list.Last().Add(new Vector2(-101f, -104f));
		list.Last().Add(new Vector2(-109f, -82f));
		list.Last().Add(new Vector2(-107f, -50f));
		list.Last().Add(new Vector2(-79f, -12f));
		list.Last().Add(new Vector2(-49f, 0f));
		list.Last().Add(new Vector2(-1f, -2f));
		list.Last().Add(new Vector2(19f, -28f));
		list.Last().Add(new Vector2(34f, -61f));
		list.Last().Add(new Vector2(62f, -2f));
		list.Last().Add(new Vector2(67f, -1f));
		list.Last().Add(new Vector2(111f, -31f));
		list.Last().Add(new Vector2(91f, -42f));
		list.Last().Add(new Vector2(66f, -27f));
		list.Last().Add(new Vector2(39f, -75f));
		list.Last().Add(new Vector2(40f, -102f));
		list.Last().Add(new Vector2(26f, -107f));
		list.Last().Add(new Vector2(-1f, -135f));
		list.Last().Add(new Vector2(-51f, -143f));
		list.Last().Add(new Vector2(-82f, -137f));
		list.Last().Add(new Vector2(-81f, -243f));
		list3.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateMicroscopeTable(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(238, 1874, 311, 279), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 113.5999f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-127f, -230f));
		list.Last().Add(new Vector2(-126f, -195f));
		list.Last().Add(new Vector2(-114f, -194f));
		list.Last().Add(new Vector2(-112f, -3f));
		list.Last().Add(new Vector2(112f, -3f));
		list.Last().Add(new Vector2(112f, -195f));
		list.Last().Add(new Vector2(126f, -195f));
		list.Last().Add(new Vector2(125f, -230f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(802, 1887, 149, 190), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(70.39997f, 302.4006f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-120f, -369f));
		list.Last().Add(new Vector2(-100f, -351f));
		list.Last().Add(new Vector2(-99f, -336f));
		list.Last().Add(new Vector2(-114f, -327f));
		list.Last().Add(new Vector2(-115f, -252f));
		list.Last().Add(new Vector2(-119f, -250f));
		list.Last().Add(new Vector2(-120f, -233f));
		list.Last().Add(new Vector2(-27f, -233f));
		list.Last().Add(new Vector2(-27f, -252f));
		list.Last().Add(new Vector2(-40f, -262f));
		list.Last().Add(new Vector2(-51f, -268f));
		list.Last().Add(new Vector2(-66f, -270f));
		list.Last().Add(new Vector2(-30f, -283f));
		list.Last().Add(new Vector2(-31f, -331f));
		list.Last().Add(new Vector2(-51f, -342f));
		list.Last().Add(new Vector2(-51f, -353f));
		list.Last().Add(new Vector2(-73f, -357f));
		list.Last().Add(new Vector2(-79f, -355f));
		list.Last().Add(new Vector2(-111f, -376f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(777, 2082, 146, 99), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-47.99999f, 259.2004f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(3f, -274f));
		list.Last().Add(new Vector2(3f, -234f));
		list.Last().Add(new Vector2(96f, -233f));
		list.Last().Add(new Vector2(96f, -270f));
		list.Last().Add(new Vector2(86f, -272f));
		list.Last().Add(new Vector2(83f, -296f));
		list.Last().Add(new Vector2(16f, -294f));
		list.Last().Add(new Vector2(16f, -274f));
		list3.Add(2);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(802, 1887, 149, 190), default(Vector2), -0.98f));
		list2.Last().Last().Origin = new Vector2(70.39997f, 302.4006f);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateLabChair(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(615, 1885, 145, 300), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(8f, 134.3999f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-48f, -4f));
		list.Last().Add(new Vector2(-30f, -2f));
		list.Last().Add(new Vector2(-30f, -16f));
		list.Last().Add(new Vector2(18f, -16f));
		list.Last().Add(new Vector2(19f, -3f));
		list.Last().Add(new Vector2(40f, -2f));
		list.Last().Add(new Vector2(36f, -19f));
		list.Last().Add(new Vector2(38f, -163f));
		list.Last().Add(new Vector2(44f, -163f));
		list.Last().Add(new Vector2(46f, -271f));
		list.Last().Add(new Vector2(30f, -270f));
		list.Last().Add(new Vector2(28f, -186f));
		list.Last().Add(new Vector2(-62f, -184f));
		list.Last().Add(new Vector2(-60f, -165f));
		list.Last().Add(new Vector2(-47f, -164f));
		list.Last().Add(new Vector2(-45f, -18f));
		list.Last().Add(new Vector2(-50f, -17f));
		list3.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateLabTable1(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(247, 1879, 303, 265), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 115.1999f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-131f, -196f));
		list.Last().Add(new Vector2(-117f, -194f));
		list.Last().Add(new Vector2(-117f, -2f));
		list.Last().Add(new Vector2(107f, -3f));
		list.Last().Add(new Vector2(108f, -194f));
		list.Last().Add(new Vector2(122f, -195f));
		list.Last().Add(new Vector2(122f, -229f));
		list.Last().Add(new Vector2(-132f, -230f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(958, 2088, 124, 105), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(75.19997f, 268.8004f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-121f, -293f));
		list.Last().Add(new Vector2(-120f, -235f));
		list.Last().Add(new Vector2(-36f, -235f));
		list.Last().Add(new Vector2(-36f, -294f));
		list.Last().Add(new Vector2(-95f, -294f));
		list.Last().Add(new Vector2(-95f, -306f));
		list.Last().Add(new Vector2(-112f, -306f));
		list.Last().Add(new Vector2(-114f, -293f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(648, 2355, 158, 121), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-47.99999f, 260.8004f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-4f, -299f));
		list.Last().Add(new Vector2(-4f, -236f));
		list.Last().Add(new Vector2(102f, -237f));
		list.Last().Add(new Vector2(102f, -299f));
		list.Last().Add(new Vector2(88f, -300f));
		list.Last().Add(new Vector2(87f, -255f));
		list.Last().Add(new Vector2(10f, -254f));
		list.Last().Add(new Vector2(10f, -298f));
		list3.Add(2);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(705, 2234, 66, 109), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-25.6f, 286.4005f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(32f, -323f));
		list.Last().Add(new Vector2(15f, -323f));
		list.Last().Add(new Vector2(15f, -258f));
		list.Last().Add(new Vector2(34f, -257f));
		list3.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(703, 2237, 69, 107), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(-46.39999f, 284.8005f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(56f, -324f));
		list.Last().Add(new Vector2(37f, -324f));
		list.Last().Add(new Vector2(37f, -258f));
		list.Last().Add(new Vector2(56f, -258f));
		list3.Add(4);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(706, 2234, 61, 104), default(Vector2), 0.05999999f));
		list2.Last().Last().Origin = new Vector2(-71.99997f, 289.6005f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(64f, -325f));
		list.Last().Add(new Vector2(63f, -259f));
		list.Last().Add(new Vector2(83f, -260f));
		list.Last().Add(new Vector2(82f, -325f));
		list3.Add(5);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreatePillsTable(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(241, 1878, 308, 269), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 113.5999f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-129f, -229f));
		list.Last().Add(new Vector2(-127f, -195f));
		list.Last().Add(new Vector2(-115f, -195f));
		list.Last().Add(new Vector2(-114f, -2f));
		list.Last().Add(new Vector2(111f, -3f));
		list.Last().Add(new Vector2(109f, -194f));
		list.Last().Add(new Vector2(125f, -194f));
		list.Last().Add(new Vector2(125f, -227f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(992, 1878, 76, 91), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(40f, 262.4004f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-60f, -291f));
		list.Last().Add(new Vector2(-60f, -277f));
		list.Last().Add(new Vector2(-58f, -276f));
		list.Last().Add(new Vector2(-57f, -234f));
		list.Last().Add(new Vector2(-27f, -234f));
		list.Last().Add(new Vector2(-26f, -274f));
		list.Last().Add(new Vector2(-25f, -292f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(988, 1879, 79, 97), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(92.79995f, 256.0004f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-111f, -289f));
		list.Last().Add(new Vector2(-109f, -275f));
		list.Last().Add(new Vector2(-108f, -271f));
		list.Last().Add(new Vector2(-107f, -232f));
		list.Last().Add(new Vector2(-77f, -232f));
		list.Last().Add(new Vector2(-75f, -274f));
		list.Last().Add(new Vector2(-76f, -290f));
		list3.Add(2);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(988, 1874, 88, 98), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-11.2f, 259.2004f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-10f, -287f));
		list.Last().Add(new Vector2(-9f, -273f));
		list.Last().Add(new Vector2(-7f, -232f));
		list.Last().Add(new Vector2(21f, -232f));
		list.Last().Add(new Vector2(24f, -289f));
		list3.Add(3);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(988, 2000, 86, 80), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(-75.19997f, 251.2004f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(54f, -277f));
		list.Last().Add(new Vector2(54f, -232f));
		list.Last().Add(new Vector2(92f, -232f));
		list.Last().Add(new Vector2(92f, -265f));
		list.Last().Add(new Vector2(98f, -274f));
		list3.Add(4);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(992, 1878, 76, 91), default(Vector2), -0.98f));
		list2.Last().Last().Origin = new Vector2(40f, 262.4004f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(988, 1879, 79, 97), default(Vector2), -0.97f));
		list2.Last().Last().Origin = new Vector2(92.79995f, 256.0004f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(988, 1874, 88, 98), default(Vector2), -0.96f));
		list2.Last().Last().Origin = new Vector2(-11.2f, 259.2004f);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateLabCabinet(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(220, 2163, 339, 446), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 196.8002f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-145f, -395f));
		list.Last().Add(new Vector2(-144f, -2f));
		list.Last().Add(new Vector2(140f, -2f));
		list.Last().Add(new Vector2(139f, -394f));
		list3.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateSurgeryScreens(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1632, 1812, 229, 420), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(4.799998f, 180.8001f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-97f, -62f));
		list.Last().Add(new Vector2(-95f, -35f));
		list.Last().Add(new Vector2(-91f, -13f));
		list.Last().Add(new Vector2(-84f, -4f));
		list.Last().Add(new Vector2(-68f, -3f));
		list.Last().Add(new Vector2(-58f, -20f));
		list.Last().Add(new Vector2(-54f, -35f));
		list.Last().Add(new Vector2(44f, -36f));
		list.Last().Add(new Vector2(49f, -14f));
		list.Last().Add(new Vector2(58f, -4f));
		list.Last().Add(new Vector2(71f, -3f));
		list.Last().Add(new Vector2(81f, -15f));
		list.Last().Add(new Vector2(80f, -36f));
		list.Last().Add(new Vector2(80f, -301f));
		list.Last().Add(new Vector2(67f, -302f));
		list.Last().Add(new Vector2(63f, -342f));
		list.Last().Add(new Vector2(43f, -359f));
		list.Last().Add(new Vector2(31f, -357f));
		list.Last().Add(new Vector2(28f, -212f));
		list.Last().Add(new Vector2(-87f, -212f));
		list.Last().Add(new Vector2(-86f, -196f));
		list.Last().Add(new Vector2(33f, -198f));
		list.Last().Add(new Vector2(33f, -116f));
		list.Last().Add(new Vector2(-79f, -114f));
		list.Last().Add(new Vector2(-80f, -64f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1480, 2047, 134, 122), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(30.40001f, 144f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-75f, -119f));
		list.Last().Add(new Vector2(-50f, -118f));
		list.Last().Add(new Vector2(9f, -124f));
		list.Last().Add(new Vector2(9f, -174f));
		list.Last().Add(new Vector2(-12f, -173f));
		list.Last().Add(new Vector2(-52f, -190f));
		list.Last().Add(new Vector2(-72f, -190f));
		list3.Add(1);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateSink(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1683, 2288, 206, 279), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 116.7999f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-78f, -166f));
		list.Last().Add(new Vector2(-76f, -146f));
		list.Last().Add(new Vector2(-61f, -122f));
		list.Last().Add(new Vector2(-60f, -3f));
		list.Last().Add(new Vector2(60f, -1f));
		list.Last().Add(new Vector2(59f, -123f));
		list.Last().Add(new Vector2(77f, -143f));
		list.Last().Add(new Vector2(78f, -166f));
		list.Last().Add(new Vector2(69f, -166f));
		list.Last().Add(new Vector2(69f, -190f));
		list.Last().Add(new Vector2(15f, -188f));
		list.Last().Add(new Vector2(14f, -233f));
		list.Last().Add(new Vector2(-13f, -233f));
		list.Last().Add(new Vector2(-13f, -187f));
		list.Last().Add(new Vector2(-68f, -188f));
		list.Last().Add(new Vector2(-67f, -164f));
		list3.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateCoatStand(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1985, 1851, 171, 344), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 153.6f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-71f, -39f));
		list.Last().Add(new Vector2(-70f, -3f));
		list.Last().Add(new Vector2(64f, -3f));
		list.Last().Add(new Vector2(63f, -38f));
		list.Last().Add(new Vector2(45f, -40f));
		list.Last().Add(new Vector2(42f, -303f));
		list.Last().Add(new Vector2(-55f, -302f));
		list.Last().Add(new Vector2(-55f, -40f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1881, 1857, 105, 284), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(11.2f, 174.4001f);
		list7.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-13f, -295f));
		list.Last().Add(new Vector2(-26f, -265f));
		list.Last().Add(new Vector2(-39f, -51f));
		list.Last().Add(new Vector2(22f, -46f));
		list.Last().Add(new Vector2(25f, -141f));
		list.Last().Add(new Vector2(4f, -292f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(-7f, -291f));
		list5.Add(PhysicsJointType.FLOPPY_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateSurgeryCabinet(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1416, 2253, 239, 373), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 164.8f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-99f, -334f));
		list.Last().Add(new Vector2(-99f, -3f));
		list.Last().Add(new Vector2(97f, -2f));
		list.Last().Add(new Vector2(97f, -336f));
		list3.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateDeadBody(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1125, 2854, 472, 211), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(0f, 83.19996f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-206f, -169f));
		list.Last().Add(new Vector2(-206f, -146f));
		list.Last().Add(new Vector2(-195f, -145f));
		list.Last().Add(new Vector2(-197f, -66f));
		list.Last().Add(new Vector2(-208f, -67f));
		list.Last().Add(new Vector2(-208f, -3f));
		list.Last().Add(new Vector2(204f, -2f));
		list.Last().Add(new Vector2(202f, -67f));
		list.Last().Add(new Vector2(189f, -66f));
		list.Last().Add(new Vector2(189f, -144f));
		list.Last().Add(new Vector2(198f, -143f));
		list.Last().Add(new Vector2(197f, -171f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1221, 2746, 278, 102), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(0f, 201.6002f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-119f, -235f));
		list.Last().Add(new Vector2(-120f, -173f));
		list.Last().Add(new Vector2(119f, -175f));
		list.Last().Add(new Vector2(98f, -236f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1239, 2659, 197, 84), default(Vector2), 0.05999999f));
		list2.Last().Last().Origin = new Vector2(-28.8f, 198.4002f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(95f, -209f));
		list.Last().Add(new Vector2(-23f, -220f));
		list.Last().Add(new Vector2(-44f, -208f));
		list.Last().Add(new Vector2(-19f, -181f));
		list.Last().Add(new Vector2(-10f, -179f));
		list.Last().Add(new Vector2(94f, -190f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1514, 2714, 177, 119), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-160f, 217.6003f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(130f, -245f));
		list.Last().Add(new Vector2(131f, -211f));
		list.Last().Add(new Vector2(96f, -212f));
		list.Last().Add(new Vector2(98f, -177f));
		list.Last().Add(new Vector2(219f, -178f));
		list.Last().Add(new Vector2(221f, -253f));
		list.Last().Add(new Vector2(181f, -249f));
		list.Last().Add(new Vector2(151f, -265f));
		list.Last().Add(new Vector2(151f, -247f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1019, 2748, 183, 97), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(164.8f, 203.2002f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-233f, -234f));
		list.Last().Add(new Vector2(-233f, -177f));
		list.Last().Add(new Vector2(-97f, -176f));
		list.Last().Add(new Vector2(-98f, -226f));
		list.Last().Add(new Vector2(-210f, -209f));
		list.Last().Add(new Vector2(-207f, -240f));
		list6.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1128, 2656, 66, 78), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(201.6002f, 244.8004f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-212f, -269f));
		list.Last().Add(new Vector2(-221f, -232f));
		list.Last().Add(new Vector2(-215f, -222f));
		list.Last().Add(new Vector2(-184f, -252f));
		list6.Add(1);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1221, 2746, 278, 102), default(Vector2), -1.05f));
		list2.Last().Last().Origin = new Vector2(0f, 201.6002f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1239, 2659, 197, 84), default(Vector2), -1.06f));
		list2.Last().Last().Origin = new Vector2(-28.8f, 198.4002f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1514, 2714, 177, 119), default(Vector2), -1.04f));
		list2.Last().Last().Origin = new Vector2(-160f, 217.6003f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1019, 2748, 183, 97), default(Vector2), -1.04f));
		list2.Last().Last().Origin = new Vector2(164.8f, 203.2002f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(1128, 2656, 66, 78), default(Vector2), -1.05f));
		list2.Last().Last().Origin = new Vector2(201.6002f, 244.8004f);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(84f, -199f));
		list5.Add(PhysicsJointType.LOOSE_JOINT);
		list3.Add(1);
		list3.Add(3);
		list4.Add(new Vector2(100f, -196f));
		list5.Add(PhysicsJointType.LOOSE_JOINT);
		list3.Add(1);
		list3.Add(4);
		list4.Add(new Vector2(-98f, -202f));
		list5.Add(PhysicsJointType.LOOSE_JOINT);
		list3.Add(4);
		list3.Add(5);
		list4.Add(new Vector2(-214f, -228f));
		list5.Add(PhysicsJointType.LOOSE_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateDeadShelves1(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1943, 2781, 565, 339), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 137.5999f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-262f, -289f));
		list.Last().Add(new Vector2(-261f, -2f));
		list.Last().Add(new Vector2(247f, -1f));
		list.Last().Add(new Vector2(247f, -290f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1724, 2945, 210, 164), default(Vector2), 0f));
		list2.Last().Last().Origin = new Vector2(308.8006f, 73.59997f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-391f, -136f));
		list.Last().Add(new Vector2(-390f, -9f));
		list.Last().Add(new Vector2(-249f, -15f));
		list.Last().Add(new Vector2(-228f, -32f));
		list.Last().Add(new Vector2(-238f, -66f));
		list.Last().Add(new Vector2(-321f, -69f));
		list.Last().Add(new Vector2(-323f, -128f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1842, 2779, 77, 162), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(270.4005f, 217.6003f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-259f, -278f));
		list.Last().Add(new Vector2(-285f, -279f));
		list.Last().Add(new Vector2(-283f, -163f));
		list.Last().Add(new Vector2(-257f, -160f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(-243f, -46f));
		list5.Add(PhysicsJointType.ULTRAFIRM_JOINT);
		list3.Add(0);
		list3.Add(2);
		list4.Add(new Vector2(-258f, -221f));
		list5.Add(PhysicsJointType.ULTRAFIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateDeadShelves2(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1941, 2777, 561, 332), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(0f, 145.6f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-256f, -289f));
		list.Last().Add(new Vector2(-257f, -2f));
		list.Last().Add(new Vector2(250f, -2f));
		list.Last().Add(new Vector2(251f, -291f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2518, 2785, 311, 165), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(-336.0007f, 216.0002f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(403f, -218f));
		list.Last().Add(new Vector2(229f, -218f));
		list.Last().Add(new Vector2(201f, -178f));
		list.Last().Add(new Vector2(208f, -160f));
		list.Last().Add(new Vector2(443f, -159f));
		list.Last().Add(new Vector2(447f, -147f));
		list.Last().Add(new Vector2(467f, -152f));
		list.Last().Add(new Vector2(466f, -276f));
		list.Last().Add(new Vector2(402f, -265f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(1846, 2783, 64, 153), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-256.0004f, 71.99997f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(270f, -132f));
		list.Last().Add(new Vector2(244f, -132f));
		list.Last().Add(new Vector2(245f, -16f));
		list.Last().Add(new Vector2(270f, -15f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(219f, -191f));
		list5.Add(PhysicsJointType.ULTRAFIRM_JOINT);
		list3.Add(0);
		list3.Add(2);
		list4.Add(new Vector2(251f, -73f));
		list5.Add(PhysicsJointType.ULTRAFIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateExamBedEmpty(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2189, 1932, 533, 240), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 99.19994f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-222f, -187f));
		list.Last().Add(new Vector2(-234f, -156f));
		list.Last().Add(new Vector2(-225f, -93f));
		list.Last().Add(new Vector2(-206f, -81f));
		list.Last().Add(new Vector2(-205f, -1f));
		list.Last().Add(new Vector2(152f, -1f));
		list.Last().Add(new Vector2(154f, -115f));
		list.Last().Add(new Vector2(201f, -111f));
		list.Last().Add(new Vector2(222f, -109f));
		list.Last().Add(new Vector2(247f, -139f));
		list.Last().Add(new Vector2(243f, -159f));
		list.Last().Add(new Vector2(225f, -180f));
		list.Last().Add(new Vector2(201f, -188f));
		list3.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateExamBedFull(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2201, 1925, 521, 252), default(Vector2), 0f));
		list2.Last().Last().Origin = new Vector2(0f, 102.3999f);
		list7.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-228f, -189f));
		list.Last().Add(new Vector2(-240f, -157f));
		list.Last().Add(new Vector2(-231f, -98f));
		list.Last().Add(new Vector2(-211f, -92f));
		list.Last().Add(new Vector2(-211f, -3f));
		list.Last().Add(new Vector2(146f, -4f));
		list.Last().Add(new Vector2(148f, -123f));
		list.Last().Add(new Vector2(172f, -121f));
		list.Last().Add(new Vector2(194f, -113f));
		list.Last().Add(new Vector2(218f, -116f));
		list.Last().Add(new Vector2(242f, -139f));
		list.Last().Add(new Vector2(238f, -160f));
		list.Last().Add(new Vector2(218f, -185f));
		list.Last().Add(new Vector2(195f, -191f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3056, 1966, 147, 196), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(38.4f, 248.0004f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-80f, -324f));
		list.Last().Add(new Vector2(-94f, -174f));
		list.Last().Add(new Vector2(16f, -171f));
		list.Last().Add(new Vector2(-2f, -322f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3205, 2003, 101, 149), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(71.99997f, 131.1999f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-91f, -188f));
		list.Last().Add(new Vector2(-96f, -176f));
		list.Last().Add(new Vector2(-98f, -121f));
		list.Last().Add(new Vector2(-103f, -119f));
		list.Last().Add(new Vector2(-104f, -82f));
		list.Last().Add(new Vector2(-42f, -82f));
		list.Last().Add(new Vector2(-45f, -118f));
		list.Last().Add(new Vector2(-48f, -173f));
		list.Last().Add(new Vector2(-68f, -190f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3311, 2002, 101, 150), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-2.384186E-07f, 131.1999f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(0f, -188f));
		list.Last().Add(new Vector2(-25f, -184f));
		list.Last().Add(new Vector2(-29f, -167f));
		list.Last().Add(new Vector2(-31f, -117f));
		list.Last().Add(new Vector2(-31f, -81f));
		list.Last().Add(new Vector2(32f, -83f));
		list.Last().Add(new Vector2(29f, -120f));
		list.Last().Add(new Vector2(18f, -120f));
		list.Last().Add(new Vector2(24f, -172f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2733, 1972, 100, 188), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(92.79995f, 243.2003f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-79f, -322f));
		list.Last().Add(new Vector2(-60f, -284f));
		list.Last().Add(new Vector2(-78f, -208f));
		list.Last().Add(new Vector2(-86f, -192f));
		list.Last().Add(new Vector2(-94f, -181f));
		list.Last().Add(new Vector2(-118f, -191f));
		list.Last().Add(new Vector2(-118f, -207f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2846, 1977, 81, 170), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(-14.4f, 248.0004f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-2f, -321f));
		list.Last().Add(new Vector2(-12f, -289f));
		list.Last().Add(new Vector2(7f, -207f));
		list.Last().Add(new Vector2(0f, -196f));
		list.Last().Add(new Vector2(25f, -183f));
		list.Last().Add(new Vector2(38f, -201f));
		list.Last().Add(new Vector2(38f, -219f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2930, 1975, 122, 154), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(35.2f, 363.2008f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-56f, -338f));
		list.Last().Add(new Vector2(-56f, -311f));
		list.Last().Add(new Vector2(-12f, -314f));
		list.Last().Add(new Vector2(-17f, -336f));
		list.Last().Add(new Vector2(-5f, -340f));
		list.Last().Add(new Vector2(-4f, -384f));
		list.Last().Add(new Vector2(5f, -405f));
		list.Last().Add(new Vector2(-7f, -420f));
		list.Last().Add(new Vector2(-16f, -412f));
		list.Last().Add(new Vector2(-43f, -417f));
		list.Last().Add(new Vector2(-75f, -412f));
		list.Last().Add(new Vector2(-79f, -396f));
		list.Last().Add(new Vector2(-72f, -384f));
		list.Last().Add(new Vector2(-73f, -338f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(-40f, -178f));
		list5.Add(PhysicsJointType.ULTRAFIRM_JOINT);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(-78f, -179f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(3);
		list4.Add(new Vector2(-1f, -177f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(4);
		list3.Add(1);
		list4.Add(new Vector2(-73f, -306f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(5);
		list3.Add(1);
		list4.Add(new Vector2(-6f, -307f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(6);
		list3.Add(1);
		list4.Add(new Vector2(-35f, -309f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateDocExaminer(PhysicsOutfit outfit)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3140, 2249, 107, 189), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 75.19997f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-42f, -29f));
		list.Last().Add(new Vector2(-40f, -4f));
		list.Last().Add(new Vector2(32f, -2f));
		list.Last().Add(new Vector2(31f, -150f));
		list.Last().Add(new Vector2(-7f, -143f));
		list.Last().Add(new Vector2(0f, -31f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2898, 2205, 127, 245), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(-6.4f, 212.8002f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-23f, -312f));
		list.Last().Add(new Vector2(-39f, -117f));
		list.Last().Add(new Vector2(54f, -120f));
		list.Last().Add(new Vector2(35f, -309f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2805, 2220, 90, 197), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-6.4f, 228.8003f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-1f, -304f));
		list.Last().Add(new Vector2(-6f, -179f));
		list.Last().Add(new Vector2(-4f, -165f));
		list.Last().Add(new Vector2(18f, -147f));
		list.Last().Add(new Vector2(36f, -165f));
		list.Last().Add(new Vector2(34f, -181f));
		list.Last().Add(new Vector2(21f, -296f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3026, 2200, 113, 160), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(-1.599998f, 356.8008f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-3f, -323f));
		list.Last().Add(new Vector2(-3f, -299f));
		list.Last().Add(new Vector2(29f, -299f));
		list.Last().Add(new Vector2(32f, -358f));
		list.Last().Add(new Vector2(34f, -383f));
		list.Last().Add(new Vector2(29f, -406f));
		list.Last().Add(new Vector2(6f, -411f));
		list.Last().Add(new Vector2(-21f, -407f));
		list.Last().Add(new Vector2(-41f, -387f));
		list.Last().Add(new Vector2(-31f, -384f));
		list.Last().Add(new Vector2(-31f, -364f));
		list.Last().Add(new Vector2(-42f, -348f));
		list.Last().Add(new Vector2(-32f, -348f));
		list.Last().Add(new Vector2(-31f, -320f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(11f, -144f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(13f, -295f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		list3.Add(1);
		list3.Add(3);
		list4.Add(new Vector2(14f, -303f));
		list5.Add(PhysicsJointType.FIRM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}

	public static void CreateExamDesk(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> connections = new List<int>();
		List<Vector2> jointPos = new List<Vector2>();
		List<PhysicsJointType> jointTypes = new List<PhysicsJointType>();
		List<int> list3 = new List<int>();
		List<MassTypes> list4 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3291, 2332, 197, 265), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(0f, 110.3999f);
		list4.Add(MassTypes.HEAVY_MASS);
		list.Last().Add(new Vector2(-80f, -225f));
		list.Last().Add(new Vector2(-80f, -194f));
		list.Last().Add(new Vector2(-69f, -192f));
		list.Last().Add(new Vector2(-68f, -2f));
		list.Last().Add(new Vector2(72f, -1f));
		list.Last().Add(new Vector2(72f, -189f));
		list.Last().Add(new Vector2(76f, -193f));
		list.Last().Add(new Vector2(78f, -227f));
		list3.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3274, 2212, 94, 97), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(46.39999f, 259.2004f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-67f, -278f));
		list.Last().Add(new Vector2(-64f, -230f));
		list.Last().Add(new Vector2(-21f, -230f));
		list.Last().Add(new Vector2(-20f, -291f));
		list.Last().Add(new Vector2(-66f, -290f));
		list3.Add(1);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(3375, 2245, 118, 59), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-33.6f, 238.4003f);
		list4.Add(MassTypes.MED_MASS);
		list.Last().Add(new Vector2(-9f, -243f));
		list.Last().Add(new Vector2(-10f, -232f));
		list.Last().Add(new Vector2(74f, -231f));
		list.Last().Add(new Vector2(74f, -245f));
		list.Last().Add(new Vector2(-2f, -247f));
		list3.Add(2);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(null);
		list2.Last().Add(null);
		list2.Last().Add(null);
		outfit.Initialize(list, list2, connections, jointPos, jointTypes, list4, list3);
	}

	public static void CreateSkeleton(PhysicsOutfit outfit)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09db: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Unknown result type (might be due to invalid IL or missing references)
		List<List<Vector2>> list = new List<List<Vector2>>();
		List<List<RenderSprite>> list2 = new List<List<RenderSprite>>();
		List<int> list3 = new List<int>();
		List<Vector2> list4 = new List<Vector2>();
		List<PhysicsJointType> list5 = new List<PhysicsJointType>();
		List<int> list6 = new List<int>();
		List<MassTypes> list7 = new List<MassTypes>();
		list2.Add(new List<RenderSprite>());
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2541, 2272, 236, 473), default(Vector2), 0f));
		list2.Last().Last().Origin = new Vector2(-44.79999f, 206.4002f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-49f, -422f));
		list.Last().Add(new Vector2(-48f, -402f));
		list.Last().Add(new Vector2(57f, -401f));
		list.Last().Add(new Vector2(59f, -29f));
		list.Last().Add(new Vector2(-58f, -29f));
		list.Last().Add(new Vector2(-58f, -1f));
		list.Last().Add(new Vector2(135f, 0f));
		list.Last().Add(new Vector2(134f, -27f));
		list.Last().Add(new Vector2(93f, -29f));
		list.Last().Add(new Vector2(90f, -424f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2347, 2212, 146, 144), default(Vector2), 0.02f));
		list2.Last().Last().Origin = new Vector2(40f, 347.2007f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(2f, -391f));
		list.Last().Add(new Vector2(-77f, -393f));
		list.Last().Add(new Vector2(-77f, -324f));
		list.Last().Add(new Vector2(-57f, -323f));
		list.Last().Add(new Vector2(-58f, -299f));
		list.Last().Add(new Vector2(-11f, -298f));
		list.Last().Add(new Vector2(-12f, -323f));
		list.Last().Add(new Vector2(3f, -325f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2356, 2355, 137, 190), default(Vector2), 0.01f));
		list2.Last().Last().Origin = new Vector2(35.2f, 235.2003f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(11f, -309f));
		list.Last().Add(new Vector2(-92f, -310f));
		list.Last().Add(new Vector2(-79f, -296f));
		list.Last().Add(new Vector2(-82f, -233f));
		list.Last().Add(new Vector2(-55f, -217f));
		list.Last().Add(new Vector2(-55f, -203f));
		list.Last().Add(new Vector2(-82f, -196f));
		list.Last().Add(new Vector2(-77f, -177f));
		list.Last().Add(new Vector2(-50f, -171f));
		list.Last().Add(new Vector2(-20f, -169f));
		list.Last().Add(new Vector2(4f, -177f));
		list.Last().Add(new Vector2(7f, -199f));
		list.Last().Add(new Vector2(-22f, -203f));
		list.Last().Add(new Vector2(-29f, -221f));
		list.Last().Add(new Vector2(4f, -228f));
		list.Last().Add(new Vector2(4f, -288f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2363, 2548, 85, 178), default(Vector2), 0.015f));
		list2.Last().Last().Origin = new Vector2(63.99998f, 94.39995f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-68f, -167f));
		list.Last().Add(new Vector2(-82f, -45f));
		list.Last().Add(new Vector2(-89f, -40f));
		list.Last().Add(new Vector2(-91f, -25f));
		list.Last().Add(new Vector2(-47f, -22f));
		list.Last().Add(new Vector2(-50f, -41f));
		list.Last().Add(new Vector2(-62f, -43f));
		list.Last().Add(new Vector2(-62f, -163f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2456, 2555, 90, 174), default(Vector2), 0.03f));
		list2.Last().Last().Origin = new Vector2(-11.2f, 97.59995f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-11f, -165f));
		list.Last().Add(new Vector2(-5f, -104f));
		list.Last().Add(new Vector2(-6f, -49f));
		list.Last().Add(new Vector2(-14f, -43f));
		list.Last().Add(new Vector2(-13f, -31f));
		list.Last().Add(new Vector2(29f, -32f));
		list.Last().Add(new Vector2(29f, -46f));
		list.Last().Add(new Vector2(21f, -48f));
		list.Last().Add(new Vector2(11f, -111f));
		list.Last().Add(new Vector2(-2f, -168f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2269, 2356, 71, 197), default(Vector2), 0.04f));
		list2.Last().Last().Origin = new Vector2(99.19994f, 216.0002f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(-105f, -296f));
		list.Last().Add(new Vector2(-119f, -168f));
		list.Last().Add(new Vector2(-117f, -140f));
		list.Last().Add(new Vector2(-95f, -139f));
		list.Last().Add(new Vector2(-92f, -166f));
		list.Last().Add(new Vector2(-97f, -233f));
		list.Last().Add(new Vector2(-90f, -297f));
		list6.Add(0);
		list.Add(new List<Vector2>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsUpper", new Rectangle(2271, 2564, 72, 190), default(Vector2), 0.05f));
		list2.Last().Last().Origin = new Vector2(-28.8f, 212.8002f);
		list7.Add(MassTypes.FLESH_MASS);
		list.Last().Add(new Vector2(26f, -293f));
		list.Last().Add(new Vector2(13f, -291f));
		list.Last().Add(new Vector2(19f, -232f));
		list.Last().Add(new Vector2(19f, -145f));
		list.Last().Add(new Vector2(43f, -144f));
		list.Last().Add(new Vector2(44f, -172f));
		list.Last().Add(new Vector2(30f, -238f));
		list6.Add(0);
		list2.Add(new List<RenderSprite>());
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2541, 2272, 236, 473), default(Vector2), -0.99f));
		list2.Last().Last().Origin = new Vector2(-44.79999f, 206.4002f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2347, 2212, 146, 144), default(Vector2), -0.98f));
		list2.Last().Last().Origin = new Vector2(40f, 347.2007f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2356, 2355, 137, 190), default(Vector2), -0.99f));
		list2.Last().Last().Origin = new Vector2(35.2f, 235.2003f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2363, 2548, 85, 178), default(Vector2), -0.98f));
		list2.Last().Last().Origin = new Vector2(63.99998f, 94.39995f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2456, 2555, 90, 174), default(Vector2), -0.97f));
		list2.Last().Last().Origin = new Vector2(-11.2f, 97.59995f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2269, 2356, 71, 197), default(Vector2), -0.96f));
		list2.Last().Last().Origin = new Vector2(99.19994f, 216.0002f);
		list2.Last().Add(SpriteManager.GetSprite("images/bodypartsGlow", new Rectangle(2271, 2564, 72, 190), default(Vector2), -0.95f));
		list2.Last().Last().Origin = new Vector2(-28.8f, 212.8002f);
		list3.Add(0);
		list3.Add(1);
		list4.Add(new Vector2(-35f, -384f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		list3.Add(1);
		list3.Add(2);
		list4.Add(new Vector2(-35f, -306f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		list3.Add(2);
		list3.Add(3);
		list4.Add(new Vector2(-63f, -175f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		list3.Add(2);
		list3.Add(4);
		list4.Add(new Vector2(-9f, -172f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		list3.Add(2);
		list3.Add(5);
		list4.Add(new Vector2(-95f, -299f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		list3.Add(2);
		list3.Add(6);
		list4.Add(new Vector2(19f, -295f));
		list5.Add(PhysicsJointType.NORM_JOINT);
		outfit.Initialize(list, list2, list3, list4, list5, list7, list6);
	}
}
