using System.Collections.Generic;
using System.Xml.Serialization;
using FarseerGames.FarseerPhysics.Interfaces;
using Microsoft.Xna.Framework.Content;

namespace FarseerGames.FarseerPhysics;

public class GenericList<T> : List<T> where T : IIsDisposable
{
	public delegate void ContentsChangedEventHandler(T element);

	private List<T> _markedForRemovalList = new List<T>();

	private int _numberDisposed;

	private int _count;

	[ContentSerializerIgnore]
	[XmlIgnore]
	public ContentsChangedEventHandler Added;

	[ContentSerializerIgnore]
	[XmlIgnore]
	public ContentsChangedEventHandler Removed;

	public GenericList(int capacity)
	{
		base.Capacity = capacity;
	}

	public new void Add(T element)
	{
		base.Add(element);
		if (Added != null)
		{
			Added(element);
		}
	}

	public new void Remove(T element)
	{
		base.Remove(element);
		if (Removed != null)
		{
			Removed(element);
		}
	}

	public int RemoveDisposed()
	{
		for (int i = 0; i < base.Count; i++)
		{
			if (base[i].IsDisposed)
			{
				_markedForRemovalList.Add(base[i]);
			}
		}
		_count = _markedForRemovalList.Count;
		for (int j = 0; j < _count; j++)
		{
			Remove(_markedForRemovalList[j]);
		}
		_numberDisposed = _markedForRemovalList.Count;
		_markedForRemovalList.Clear();
		return _numberDisposed;
	}
}
