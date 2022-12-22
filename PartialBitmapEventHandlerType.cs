using System;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(PartialBitmapEventTypeConverter))]
	public class PartialBitmapEventHandlerType : AbstractHandler
	{
		public string[] EventsToExclude;
	}
}
