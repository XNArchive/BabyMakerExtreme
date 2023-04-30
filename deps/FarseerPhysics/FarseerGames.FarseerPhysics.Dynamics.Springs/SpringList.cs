using System.Collections.Generic;

namespace FarseerGames.FarseerPhysics.Dynamics.Springs;

public class SpringList : List<Spring>
{
	public delegate void ContentsChangedEventHandler(Spring spring);

	private List<Spring> _markedForRemovalList = new List<Spring>();

	public ContentsChangedEventHandler Added;

	public ContentsChangedEventHandler Removed;

	public new void Add(Spring spring)
	{
		base.Add(spring);
		if (Added != null)
		{
			Added(spring);
		}
	}

	public new void Remove(Spring spring)
	{
		base.Remove(spring);
		if (Removed != null)
		{
			Removed(spring);
		}
	}

	public void RemoveDisposed()
	{
		for (int i = 0; i < base.Count; i++)
		{
			if (IsDisposed(base[i]))
			{
				_markedForRemovalList.Add(base[i]);
			}
		}
		for (int j = 0; j < _markedForRemovalList.Count; j++)
		{
			Remove(_markedForRemovalList[j]);
		}
		_markedForRemovalList.Clear();
	}

	internal static bool IsDisposed(Spring controller)
	{
		return controller.IsDisposed;
	}
}
