using System;
using FullSerializer;
using SteelSeries.GameSense.DeviceZone;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(ContextColorEventTypeConverter))]
	public class ContextColorEventHandlerType : AbstractHandler
	{
		public AbstractIlluminationDevice_Zone DeviceZone;

		public string ContextFrameKey;
	}
}
