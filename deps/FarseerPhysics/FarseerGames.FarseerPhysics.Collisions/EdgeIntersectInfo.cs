using Microsoft.Xna.Framework;

namespace FarseerGames.FarseerPhysics.Collisions;

public class EdgeIntersectInfo
{
	public Edge EdgeOne { get; private set; }

	public Edge EdgeTwo { get; private set; }

	public Vector2 IntersectionPoint { get; private set; }

	public EdgeIntersectInfo(Edge edgeOne, Edge edgeTwo, Vector2 intersectionPoint)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		EdgeOne = edgeOne;
		EdgeTwo = edgeTwo;
		IntersectionPoint = intersectionPoint;
	}
}
