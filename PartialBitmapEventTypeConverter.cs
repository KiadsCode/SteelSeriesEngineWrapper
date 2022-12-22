using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	public class PartialBitmapEventTypeConverter : fsDirectConverter<PartialBitmapEventHandlerType>
	{
		protected override fsResult DoSerialize(PartialBitmapEventHandlerType model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<string>(serialized, null, "device-type", "rgb-per-key-zones");
			base.SerializeMember<string>(serialized, null, "mode", "partial-bitmap");
			base.SerializeMember<bool>(serialized, null, "value_optional", true);
			base.SerializeMember<string[]>(serialized, null, "excluded-events", model.EventsToExclude);
			return fsResult.Success;
		}

		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref PartialBitmapEventHandlerType model)
		{
			return fsResult.Fail("Not implemented");
		}
	}
}
