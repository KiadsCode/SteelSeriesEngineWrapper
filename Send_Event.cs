using System;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(SendEventConverter))]
	public class Send_Event
	{
		public string game;

		public string event_name;

		public EventData data;
	}
}
