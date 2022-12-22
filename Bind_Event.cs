using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(BindEventConverter))]
	public class Bind_Event
	{
		public Bind_Event(string gameName, string eventName, int minValue, int maxValue, EventIconId iconId, AbstractHandler[] handlers)
		{
			this.game = gameName;
			this.eventName = eventName;
			this.minValue = minValue;
			this.maxValue = maxValue;
			this.iconId = iconId;
			this.handlers = handlers;
			this.defaultDisplayName = eventName;
		}

		public Bind_Event(string gameName, string eventName, string defaultDisplayName, Dictionary<string, string> localizedDisplayNames, int minValue, int maxValue, EventIconId iconId, AbstractHandler[] handlers)
		{
			this.game = gameName;
			this.eventName = eventName;
			this.minValue = minValue;
			this.maxValue = maxValue;
			this.iconId = iconId;
			this.handlers = handlers;
			this.defaultDisplayName = defaultDisplayName;
			this.localizedDisplayNames = localizedDisplayNames;
		}

		[NonSerialized]
		public string game;

		public string eventName;

		public int minValue;

		public int maxValue;

		public EventIconId iconId;

		public AbstractHandler[] handlers;

		public string defaultDisplayName;

		public Dictionary<string, string> localizedDisplayNames;
	}
}
