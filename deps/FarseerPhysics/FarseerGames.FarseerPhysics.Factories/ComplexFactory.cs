using System.Collections.Generic;
using FarseerGames.FarseerPhysics.Collisions;
using FarseerGames.FarseerPhysics.Controllers;
using FarseerGames.FarseerPhysics.Dynamics;
using FarseerGames.FarseerPhysics.Dynamics.Joints;
using Microsoft.Xna.Framework;

namespace FarseerGames.FarseerPhysics.Factories;

public class ComplexFactory
{
	private static ComplexFactory _instance;

	public float Min { get; set; }

	public float Max { get; set; }

	public float SpringConstant { get; set; }

	public float DampingConstant { get; set; }

	public float SpringRestLengthFactor { get; set; }

	public static ComplexFactory Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new ComplexFactory();
			}
			return _instance;
		}
	}

	private ComplexFactory()
	{
		SpringRestLengthFactor = 1f;
	}

	public Path CreateChain(PhysicsSimulator physicsSimulator, Vector2 start, Vector2 end, int links, float height, float mass, LinkType type)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		Path path = CreateChain(start, end, Vector2.Distance(start, end) / (float)links, height, mass, type);
		path.AddToPhysicsSimulator(physicsSimulator);
		return path;
	}

	public Path CreateChain(Vector2 start, Vector2 end, int links, float height, float mass, LinkType type)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return CreateChain(start, end, Vector2.Distance(start, end) / (float)links, height, mass, type);
	}

	public Path CreateChain(PhysicsSimulator physicsSimulator, Vector2 start, Vector2 end, int links, float mass, LinkType type)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Path path = CreateChain(start, end, Vector2.Distance(start, end) / (float)links, Vector2.Distance(start, end) / (float)links * (1f / 3f), mass, type);
		path.AddToPhysicsSimulator(physicsSimulator);
		return path;
	}

	public Path CreateChain(Vector2 start, Vector2 end, int links, float mass, LinkType type)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		return CreateChain(start, end, Vector2.Distance(start, end) / (float)links, Vector2.Distance(start, end) / (float)links * (1f / 3f), mass, type);
	}

	public Path CreateChain(PhysicsSimulator physicsSimulator, Vector2 start, Vector2 end, float width, float height, float mass, LinkType type)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Path path = CreateChain(start, end, width, height, mass, pinStart: false, pinEnd: false, type);
		path.AddToPhysicsSimulator(physicsSimulator);
		return path;
	}

	public Path CreateChain(PhysicsSimulator physicsSimulator, Vector2 start, Vector2 end, float width, float height, float mass, bool pinStart, bool pinEnd, LinkType type)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Path path = CreateChain(start, end, width, height, mass, pinStart, pinEnd, type);
		path.AddToPhysicsSimulator(physicsSimulator);
		return path;
	}

	public Path CreateChain(PhysicsSimulator physicsSimulator, Vector2 start, Vector2 end, float width, float height, float linkWidth, float mass, bool pinStart, bool pinEnd, LinkType type)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Path path = CreateChain(start, end, width, height, linkWidth, mass, pinStart, pinEnd, type);
		path.AddToPhysicsSimulator(physicsSimulator);
		return path;
	}

	public Path CreateChain(Vector2 start, Vector2 end, float width, float height, float mass, LinkType type)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return CreateChain(start, end, width, height, mass, pinStart: false, pinEnd: false, type);
	}

	public Path CreateChain(Vector2 start, Vector2 end, float width, float height, float mass, bool pinStart, bool pinEnd, LinkType type)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return CreateChain(start, end, width, height, width, mass, pinStart, pinEnd, type);
	}

	public Path CreateChain(Vector2 start, Vector2 end, float width, float height, float linkWidth, float mass, bool pinStart, bool pinEnd, LinkType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		Path path = new Path(width, height, linkWidth, mass, endless: false);
		path.Add(start);
		path.Add(Vertices.FindMidpoint(start, end));
		path.Add(end);
		path.Update();
		path.LinkBodies(type, Min, Max, SpringConstant, DampingConstant, SpringRestLengthFactor);
		if (pinStart)
		{
			path.Add((Joint)JointFactory.Instance.CreateFixedRevoluteJoint(path.Bodies[0], start));
		}
		if (pinEnd)
		{
			path.Add((Joint)JointFactory.Instance.CreateFixedRevoluteJoint(path.Bodies[path.Bodies.Count - 1], path.ControlPoints[2]));
		}
		foreach (Joint joint in path.Joints)
		{
			joint.BiasFactor = 0.01f;
			joint.Softness = 0.05f;
		}
		return path;
	}

	public Path CreateTrack(Vertices points, float width, float height, float mass, bool endless, int collisionGroup, LinkType type)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		Path path = new Path(width, height, mass, endless);
		foreach (Vector2 point in points)
		{
			path.Add(point);
		}
		path.Update();
		for (int i = 0; i < path.Bodies.Count; i++)
		{
			Geom geom = GeomFactory.Instance.CreateRectangleGeom(path.Bodies[i], width, height);
			geom.CollisionGroup = collisionGroup;
			path.Add(geom);
		}
		path.LinkBodies(type, Min, Max, SpringConstant, DampingConstant);
		return path;
	}

	public Path CreateTrack(PhysicsSimulator physicsSimulator, Vertices points, float width, float height, float mass, bool endless, int collisionGroup, LinkType type)
	{
		Path path = CreateTrack(points, width, height, mass, endless, collisionGroup, type);
		path.AddToPhysicsSimulator(physicsSimulator);
		return path;
	}

	public GravityController CreateGravityController(PhysicsSimulator simulator, List<Body> bodies, GravityType type, float strength, float radius)
	{
		GravityController gravityController = new GravityController(simulator, bodies, strength, radius);
		gravityController.GravityType = type;
		simulator.Add(gravityController);
		return gravityController;
	}

	public GravityController CreateGravityController(PhysicsSimulator simulator, List<Body> bodies, float strength, float radius)
	{
		GravityController gravityController = new GravityController(simulator, bodies, strength, radius);
		simulator.Add(gravityController);
		return gravityController;
	}

	public GravityController CreateGravityController(PhysicsSimulator simulator, List<Vector2> points, GravityType type, float strength, float radius)
	{
		GravityController gravityController = new GravityController(simulator, points, strength, radius);
		gravityController.GravityType = type;
		simulator.Add(gravityController);
		return gravityController;
	}

	public GravityController CreateGravityController(PhysicsSimulator simulator, List<Vector2> points, float strength, float radius)
	{
		GravityController gravityController = new GravityController(simulator, points, strength, radius);
		simulator.Add(gravityController);
		return gravityController;
	}
}
