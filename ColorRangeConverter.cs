using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	internal class ColorRangeConverter : fsDirectConverter<ColorRange>
	{
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref ColorRange model)
		{
			return fsResult.Fail("Not implemented");
		}

		protected override fsResult DoSerialize(ColorRange model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<uint>(serialized, null, "low", model.low);
			base.SerializeMember<uint>(serialized, null, "high", model.high);
			base.SerializeMember<AbstractColor_Nonrecursive>(serialized, null, "color", model.color);
			return fsResult.Success;
		}
	}
}
