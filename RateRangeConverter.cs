using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	internal class RateRangeConverter : fsDirectConverter<RateRange>
	{
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RateRange model)
		{
			return fsResult.Fail("Not implemented");
		}

		protected override fsResult DoSerialize(RateRange model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<Frequency[]>(serialized, null, "frequency", model.frequency);
			if (model.repeatLimit != null)
			{
				base.SerializeMember<RepeatLimit[]>(serialized, null, "repeat_limit", model.repeatLimit);
			}
			return fsResult.Success;
		}
	}
}
