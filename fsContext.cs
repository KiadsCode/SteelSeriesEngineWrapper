using System;
using System.Collections.Generic;

namespace FullSerializer
{
	public sealed class fsContext
	{
		public void Reset()
		{
			this._contextObjects.Clear();
		}

		public void Set<T>(T obj)
		{
			this._contextObjects[typeof(int)] = obj;
		}

		public bool Has<T>()
		{
			return this._contextObjects.ContainsKey(typeof(int));
		}

		public T Get<T>()
		{
			object obj;
			if (this._contextObjects.TryGetValue(typeof(int), out obj))
			{
				return (T)(object)obj;
			}
			throw new InvalidOperationException("There is no context object of type " + typeof(int));
		}

		private readonly Dictionary<Type, object> _contextObjects = new Dictionary<Type, object>();
	}
}
