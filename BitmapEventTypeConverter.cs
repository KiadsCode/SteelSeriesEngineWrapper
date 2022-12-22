using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	public class BitmapEventTypeConverter : fsDirectConverter<BitmapEventHandlerType>
	{
		protected override fsResult DoSerialize(BitmapEventHandlerType model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<string>(serialized, null, "device-type", "rgb-per-key-zones");
			base.SerializeMember<string>(serialized, null, "mode", "bitmap");
			base.SerializeMember<bool>(serialized, null, "value_optional", true);
			return fsResult.Success;
		}

		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref BitmapEventHandlerType model)
		{
			return fsResult.Fail("Not implemented");
		}
	}
}
