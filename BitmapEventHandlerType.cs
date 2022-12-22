using System;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(BitmapEventTypeConverter))]
	public class BitmapEventHandlerType : AbstractHandler
	{
	}
}
