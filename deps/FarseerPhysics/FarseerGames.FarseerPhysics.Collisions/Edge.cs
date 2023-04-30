using Microsoft.Xna.Framework;

namespace FarseerGames.FarseerPhysics.Collisions;

public class Edge
{
	public Vector2 EdgeStart { get; private set; }

	public Vector2 EdgeEnd { get; private set; }

	public Edge(Vector2 edgeStart, Vector2 edgeEnd)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		EdgeStart = edgeStart;
		EdgeEnd = edgeEnd;
	}
}
