using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Renderer;

namespace Scene;

public class Room
{
	private const float SPAWN_HEIGHT = 660f;

	private Rectangle m_roomArea;

	private RoomType m_type;

	private List<Prop> m_props;

	private RoomDrawer m_roomDraw;

	public Rectangle RoomArea => m_roomArea;

	public Room()
	{
		m_props = new List<Prop>(20);
		m_roomDraw = new RoomDrawer();
	}

	public void Initialize(RoomType type, Rectangle r, PropPool pool)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		InitializeRoom(type, r);
		InitializeProps(pool);
	}

	public void InitializeWall(PropPool pool)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		Vector2 location = default(Vector2);
        location = new Vector2((float)m_roomArea.X, 670f);
		m_props.Add(pool.InitProp(PropType.WALL, location));
	}

	public void InitializeRoom(RoomType type, Rectangle r)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		m_roomArea = r;
		m_type = type;
		m_roomDraw.SetType(type);
		m_roomDraw.SetArea(m_roomArea);
	}

	public void InitializeProps(PropPool pool)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		if (m_type == RoomType.BIRTHROOM)
		{
			Vector2 location = default(Vector2);
			location = new Vector2((float)(m_roomArea.X + 150), 669f);
			m_props.Add(pool.InitProp(PropType.MOTHER, location));
			location = new Vector2((float)(m_roomArea.X + 700), 669f);
			m_props.Add(pool.InitProp(PropType.DOCTOR, location));
			location = new Vector2((float)(m_roomArea.X + 1000), 669f);
			m_props.Add(pool.InitProp(PropType.DOC_STAND, location));
			location = new Vector2((float)(m_roomArea.X + 1300), 669f);
			m_props.Add(pool.InitProp(PropType.OLD_COMP, location));
			return;
		}
		if (m_type == RoomType.CAFETERIA)
		{
			SpawnCafeteriaProps(pool);
			return;
		}
		if (m_type == RoomType.HALLWAY)
		{
			SpawnHallProps(pool);
			return;
		}
		if (m_type == RoomType.WAITINGROOM)
		{
			SpawnWaitingRoomProps(pool);
			return;
		}
		if (m_type == RoomType.BEDSROOM)
		{
			SpawnBedsProps(pool);
			return;
		}
		if (m_type == RoomType.PHYSIO)
		{
			SpawnPhysioProps(pool);
			return;
		}
		if (m_type == RoomType.LAB)
		{
			SpawnLabProps(pool);
			return;
		}
		if (m_type == RoomType.SURGERYTHEATRE)
		{
			SpawnSurgeryProps(pool);
			return;
		}
		if (m_type == RoomType.DIAGNOSIS)
		{
			SpawnExamRoom(pool);
			return;
		}
		if (m_type == RoomType.MORTUARY)
		{
			SpawnMortuary(pool);
			return;
		}
		Vector2 val = default(Vector2);
        val = new Vector2((float)m_roomArea.X, 660f);
		float num = 0f;
		PropType type = (PropType)SceneRenderer.GetRand(20f, 51f);
		num = 0f - pool.GetMinPos(type) + 50f;
		float num2 = pool.GetMaxPos(type) + 50f;
		val += new Vector2(num, 0f);
		while (val.X + num2 < (float)(m_roomArea.X + m_roomArea.Width))
		{
			m_props.Add(pool.InitProp(type, val));
			val += new Vector2(num2, 0f);
			type = (PropType)SceneRenderer.GetRand(20f, 51f);
			num = 0f - pool.GetMinPos(type) + 50f;
			num2 = pool.GetMaxPos(type) + 50f;
			val += new Vector2(num, 0f);
		}
	}

	public Vector2 QuickPropSpawn(PropType type, Vector2 startLoc, float preBufferSpace, PropPool pool)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		float num = 0f - pool.GetMinPos(type);
		float maxPos = pool.GetMaxPos(type);
		startLoc += new Vector2(preBufferSpace + num, 0f);
		m_props.Add(pool.InitProp(type, startLoc));
		startLoc += new Vector2(maxPos, 0f);
		return startLoc;
	}

	public void SpawnCafeteriaProps(PropPool pool)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
        val = new Vector2((float)m_roomArea.X, 660f);
		float rand = SceneRenderer.GetRand(0f, 1f);
		PropType type = PropType.LUNCHLADY;
		if (rand < 0.5f)
		{
			val = QuickPropSpawn(type, val, SceneRenderer.GetRand(0f, 150f), pool);
			type = PropType.GARBAGE;
		}
		else
		{
			type = PropType.LUNCHLADY;
			val += new Vector2(SceneRenderer.GetRand(0f, 100f), 0f);
		}
		int num = (int)SceneRenderer.GetRand(0f, 3f);
		do
		{
			val = ((type != PropType.CRAB_MEAL && type != PropType.LARGE_FOOD_TABLE && type != PropType.SMALL_FOOD_TABLE && type != PropType.BUFFET) ? QuickPropSpawn(type, val, 40f, pool) : QuickPropSpawn(type, val, 100f, pool));
			type = PropType.CRAB_MEAL;
			if (num == 0)
			{
				type = PropType.CRAB_MEAL;
				num = (int)SceneRenderer.GetRand(0f, 3f);
			}
			else
			{
				rand = SceneRenderer.GetRand(0f, 1f);
				type = ((rand < 0.5f) ? PropType.LARGE_FOOD_TABLE : ((!(rand < 0.8f)) ? PropType.BUFFET : PropType.SMALL_FOOD_TABLE));
				num--;
			}
		}
		while (val.X < (float)(m_roomArea.Right - 50) - (0f - pool.GetMinPos(type) + pool.GetMaxPos(type)));
	}

	public void SpawnHallProps(PropPool pool)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
        val = new Vector2((float)m_roomArea.X, 660f);
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		PropType propType = PropType.GURNEY;
		int num = 0;
		float rand = SceneRenderer.GetRand(0f, 1f);
		if (rand < 0.5f)
		{
			propType = ((!(rand < 0.25f)) ? PropType.METAL_CABINET : PropType.CABINET);
		}
		else
		{
			flag = false;
			rand = SceneRenderer.GetRand(0f, 1f);
			if (((num == 0 && rand < 0.333f) || (num == 1 && rand < 0.5f) || num == 2) && !flag2)
			{
				flag2 = true;
				propType = PropType.CRUTCHES;
				num++;
			}
			else if (((num == 0 && rand < 0.666f) || (num == 1 && flag4) || (num == 1 && flag2 && rand < 0.5f) || num == 2) && !flag3)
			{
				flag3 = true;
				propType = PropType.ELDERLY;
				num++;
			}
			else if (!flag4)
			{
				propType = PropType.GURNEY;
				flag4 = true;
				num++;
			}
			else
			{
				val += new Vector2(500f, 0f);
				propType = PropType.MAX_TYPE;
			}
		}
		do
		{
			if (propType != PropType.MAX_TYPE)
			{
				val = QuickPropSpawn(propType, val, 80f, pool);
			}
			rand = SceneRenderer.GetRand(0f, 1f);
			if ((rand < 0.5f || (flag4 && flag3 && flag4)) && !flag)
			{
				propType = ((!(rand < 0.25f)) ? PropType.METAL_CABINET : PropType.CABINET);
				flag = true;
				continue;
			}
			flag = false;
			rand = SceneRenderer.GetRand(0f, 1f);
			if (rand < 0.333f && !flag2)
			{
				flag2 = true;
				propType = PropType.CRUTCHES;
			}
			else if (rand < 0.666f && !flag3)
			{
				flag3 = true;
				propType = PropType.ELDERLY;
			}
			else if (!flag4)
			{
				propType = PropType.GURNEY;
				flag4 = true;
			}
			else
			{
				val += new Vector2(500f, 0f);
				propType = PropType.MAX_TYPE;
			}
		}
		while ((propType != PropType.MAX_TYPE && val.X < (float)(m_roomArea.Right - 90) - (0f - pool.GetMinPos(propType) + pool.GetMaxPos(propType))) || (propType == PropType.MAX_TYPE && val.X < (float)m_roomArea.Right));
	}

	public void SpawnWaitingRoomProps(PropPool pool)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		Vector2 startLoc = default(Vector2);
        startLoc = new Vector2((float)(m_roomArea.X + 100), 660f);
		float rand = SceneRenderer.GetRand(0f, 1f);
		PropType type = ((!(rand < 0.7f)) ? PropType.WAIT_CHAIR_PERSON : PropType.WAIT_CHAIR);
		int num = (int)SceneRenderer.GetRand(1f, 5f);
		do
		{
			startLoc = QuickPropSpawn(type, startLoc, 30f, pool);
			if (num > 0)
			{
				num--;
				rand = SceneRenderer.GetRand(0f, 1f);
				type = ((!(rand < 0.7f)) ? PropType.WAIT_CHAIR_PERSON : PropType.WAIT_CHAIR);
			}
			else
			{
				num = (int)SceneRenderer.GetRand(1f, 5f);
				rand = SceneRenderer.GetRand(0f, 1f);
				type = ((rand < 0.4f) ? PropType.TABLE_SM_PAMPHLET : ((!(rand < 0.8f)) ? PropType.GARBAGE : PropType.CABINET));
			}
		}
		while (startLoc.X < (float)(m_roomArea.Right - 120) - (0f - pool.GetMinPos(PropType.RECEPTION_DESK) + pool.GetMaxPos(PropType.RECEPTION_DESK)) - (0f - pool.GetMinPos(type) + pool.GetMaxPos(type)));
		QuickPropSpawn(PropType.RECEPTION_DESK, startLoc, 60f, pool);
	}

	public void SpawnBedsProps(PropPool pool)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		float num = 0f - pool.GetMinPos(PropType.FOOD_TRAY) + pool.GetMaxPos(PropType.FOOD_TRAY);
		float num2 = 0f - pool.GetMinPos(PropType.BED_PATIENT) + pool.GetMaxPos(PropType.BED_PATIENT);
		float num3 = 0f - pool.GetMinPos(PropType.BEDSIDE_TABLE) + pool.GetMaxPos(PropType.BEDSIDE_TABLE);
		Vector2 val = default(Vector2);
		val = new Vector2((float)(m_roomArea.X + 100), 660f);
		while (val.X + num + num2 + num3 + 100f < (float)m_roomArea.Right)
		{
			float rand = SceneRenderer.GetRand(0f, 1f);
			if (rand < 0.3f)
			{
				QuickPropSpawn(PropType.FOOD_TRAY, val, 0f, pool);
			}
			val += new Vector2(num + 10f, 0f);
			rand = SceneRenderer.GetRand(0f, 1f);
			if (rand < 0.5f)
			{
				QuickPropSpawn(PropType.BED_EMPTY, val, 0f, pool);
			}
			else
			{
				QuickPropSpawn(PropType.BED_PATIENT, val, 0f, pool);
			}
			val += new Vector2(num2 + 10f, 0f);
			rand = SceneRenderer.GetRand(0f, 1f);
			if (rand < 0.5f)
			{
				QuickPropSpawn(PropType.BEDSIDE_TABLE, val, 0f, pool);
			}
			else
			{
				QuickPropSpawn(PropType.BEDSIDE_TABLE_FLOWER, val, 0f, pool);
			}
			val += new Vector2(num3 + 10f, 0f);
			if (SceneRenderer.GetRand(0f, 1f) < 0.2f && val.X < (float)(m_roomArea.Right - 10) - (0f - pool.GetMinPos(PropType.BYPASS_MACHINE) + pool.GetMaxPos(PropType.BYPASS_MACHINE)))
			{
				val = QuickPropSpawn(PropType.BYPASS_MACHINE, val, 10f, pool);
			}
			val += new Vector2(70f, 0f);
		}
	}

	public void SpawnPhysioProps(PropPool pool)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		Vector2 startLoc = default(Vector2);
        startLoc = new Vector2((float)m_roomArea.X, 660f);
		for (int i = 0; i < 3; i++)
		{
			float rand = SceneRenderer.GetRand(0f, 1f);
			if ((i == 0 && rand < 0.3f) || (i == 2 && !flag) || (i == 1 && rand < 0.5f && !flag))
			{
				startLoc = QuickPropSpawn(PropType.WHEELCHAIR, startLoc, 100f, pool);
				flag = true;
			}
			else if ((i == 0 && rand < 0.6f) || (i == 2 && !flag2) || (i == 1 && !flag2 && flag3) || (i == 1 && !flag2 && !flag3 && rand < 0.5f))
			{
				startLoc = QuickPropSpawn(PropType.PHYSIO_BARS, startLoc, 100f, pool);
				flag2 = true;
			}
			else
			{
				startLoc = QuickPropSpawn(PropType.ARMLESS_GIRL, startLoc, 100f, pool);
				startLoc = QuickPropSpawn(PropType.LIMB_TABLE, startLoc, 10f, pool);
				flag3 = true;
			}
		}
	}

	public void SpawnLabProps(PropPool pool)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
        val = new Vector2((float)m_roomArea.X, 660f);
		PropType propType = PropType.LAB_GEN_TABLE1;
		float num = 0f;
		float rand = SceneRenderer.GetRand(0f, 1f);
		if (rand < 0.3f)
		{
			propType = PropType.LAB_GEN_TABLE1;
			num = 50f;
		}
		else if (rand < 0.6f)
		{
			propType = PropType.LAB_MICROSCOPE_TABLE;
			num = 50f;
		}
		else
		{
			propType = PropType.LAB_PILL_TABLE;
			num = 50f;
		}
		int num2 = (int)SceneRenderer.GetRand(1f, 4f);
		do
		{
			val = QuickPropSpawn(propType, val, 10f + num, pool);
			if (num2 > 0)
			{
				num2--;
				num = 0f;
				rand = SceneRenderer.GetRand(0f, 1f);
				if (rand < 0.4f)
				{
					propType = PropType.LAB_GEN_TABLE1;
					num = 50f;
				}
				else if (rand < 0.7f)
				{
					propType = PropType.LAB_MICROSCOPE_TABLE;
					num = 50f;
				}
				else
				{
					propType = PropType.LAB_PILL_TABLE;
					num = 50f;
				}
				if (SceneRenderer.GetRand(0f, 1f) < 0.5f)
				{
					if (val.X < (float)m_roomArea.Right - (0f - pool.GetMinPos(propType) + pool.GetMaxPos(propType) + 80f + num))
					{
						val = QuickPropSpawn(propType, val, 80f + num, pool);
						propType = PropType.LAB_CHAIR;
						num = 0f;
					}
				}
				else
				{
					val += new Vector2(70f, 0f);
				}
			}
			else
			{
				num2 = (int)SceneRenderer.GetRand(1f, 4f);
				if (SceneRenderer.GetRand(0f, 1f) < 0.5f)
				{
					propType = PropType.LAB_CABINET;
					val += new Vector2(70f, 0f);
					num = 0f;
				}
				else
				{
					propType = PropType.COAT_STAND;
					val += new Vector2(50f, 0f);
					num = 0f;
				}
			}
		}
		while (val.X < (float)m_roomArea.Right - (0f - pool.GetMinPos(propType) + pool.GetMaxPos(propType) + 50f + num));
	}

	public void SpawnSurgeryProps(PropPool pool)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		Vector2 startLoc = default(Vector2);
        startLoc = new Vector2((float)m_roomArea.X, 660f);
		startLoc = QuickPropSpawn(PropType.SURGERY_LIGHT, startLoc, 50f, pool);
		startLoc = QuickPropSpawn(PropType.SURGERY_PATIENT, startLoc, 50f, pool);
		startLoc = QuickPropSpawn(PropType.SURGEON, startLoc, 50f, pool);
		startLoc = QuickPropSpawn(PropType.SURGEON_MONITOR, startLoc, 80f, pool);
		startLoc = QuickPropSpawn(PropType.SURGERY_CABINET, startLoc, 50f, pool);
		startLoc = QuickPropSpawn(PropType.SINK, startLoc, 50f, pool);
		startLoc = QuickPropSpawn(PropType.SINK, startLoc, 50f, pool);
		startLoc = QuickPropSpawn(PropType.SINK, startLoc, 50f, pool);
		startLoc = QuickPropSpawn(PropType.SINK, startLoc, 50f, pool);
		startLoc = QuickPropSpawn(PropType.COAT_STAND, startLoc, 50f, pool);
		startLoc = QuickPropSpawn(PropType.COAT_STAND, startLoc, 50f, pool);
	}

	public void SpawnExamRoom(PropPool pool)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		Vector2 startLoc = default(Vector2);
        startLoc = new Vector2((float)m_roomArea.X, 660f);
		float rand = SceneRenderer.GetRand(0f, 1f);
		if (rand < 0.5f)
		{
			if (SceneRenderer.GetRand(0f, 1f) < 0.5f)
			{
				startLoc = QuickPropSpawn(PropType.SKELETON, startLoc, 50f, pool);
				startLoc = QuickPropSpawn(PropType.EXAM_BED_EMPTY, startLoc, 50f, pool);
				startLoc = QuickPropSpawn(PropType.DOC_EXAMINER, startLoc, 50f, pool);
				startLoc = QuickPropSpawn(PropType.EXAM_DESK, startLoc, 50f, pool);
			}
			else
			{
				startLoc = QuickPropSpawn(PropType.SKELETON, startLoc, 50f, pool);
				startLoc = QuickPropSpawn(PropType.EXAM_BED_FULL, startLoc, 50f, pool);
				startLoc = QuickPropSpawn(PropType.DOC_EXAMINER, startLoc, 50f, pool);
				startLoc = QuickPropSpawn(PropType.EXAM_DESK, startLoc, 50f, pool);
			}
		}
		else
		{
			startLoc = QuickPropSpawn(PropType.XRAY, startLoc, 100f, pool);
			startLoc = QuickPropSpawn(PropType.DOC_EXAMINER, startLoc, 70f, pool);
			startLoc = QuickPropSpawn(PropType.EXAM_DESK, startLoc, 60f, pool);
		}
	}

	public void SpawnMortuary(PropPool pool)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		Vector2 startLoc = default(Vector2);
        startLoc = new Vector2((float)m_roomArea.X, 660f);
		PropType propType = PropType.DEAD_BODY;
		propType = PropType.DEAD_SHELF1;
		propType = PropType.DEAD_SHELF2;
		propType = PropType.METAL_CABINET;
		propType = PropType.DOCTOR;
		do
		{
			startLoc = QuickPropSpawn(propType, startLoc, 80f, pool);
			PropType propType2 = propType;
			float rand = SceneRenderer.GetRand(0f, 1f);
			if (rand < 0.2f)
			{
				propType = PropType.DEAD_BODY;
			}
			else if (rand < 0.4f)
			{
				propType = PropType.DEAD_SHELF1;
			}
			else if (rand < 0.6f)
			{
				propType = PropType.DEAD_SHELF2;
			}
			else if (rand < 0.8f)
			{
				propType = PropType.METAL_CABINET;
			}
			else if (rand <= 1f)
			{
				propType = PropType.DOCTOR;
				if (propType == propType2)
				{
					propType = PropType.DEAD_BODY;
				}
			}
		}
		while (startLoc.X < (float)m_roomArea.Right - (0f - pool.GetMinPos(propType) + pool.GetMaxPos(propType) + 100f));
	}

	public void Draw(TimeTracker gameTime)
	{
		for (int i = 0; i < m_props.Count; i++)
		{
			m_props[i].Draw(gameTime);
		}
		m_roomDraw.Draw(gameTime);
	}

	public void Update(TimeTracker gameTime)
	{
		for (int i = 0; i < m_props.Count; i++)
		{
			m_props[i].Update(gameTime);
			m_props[i].UpdateEnabled();
		}
		m_roomDraw.Update(gameTime);
	}

	public void CleanRoom(PropPool pool)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < m_props.Count; i++)
		{
			m_props[i].ResetToLocation(new Vector2(-5000f, 667f));
			pool.AddProp(m_props[i]);
		}
		m_props.Clear();
		m_roomDraw.SetArea(new Rectangle(-10000, 0, 1300, 768));
	}
}
