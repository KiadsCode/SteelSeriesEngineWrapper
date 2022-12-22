using System;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(RegisterEventConverter))]
	public class Register_Event
	{
		public Register_Event(string gameName, string eventName, int minValue, int maxValue, EventIconId iconId)
		{
			this.game = gameName;
			this.eventName = eventName;
			this.minValue = minValue;
			this.maxValue = maxValue;
			this.iconId = iconId;
		}

		[NonSerialized]
		public string game;

		public string eventName;

		public int minValue;

		public int maxValue;

		public EventIconId iconId;
	}
}
