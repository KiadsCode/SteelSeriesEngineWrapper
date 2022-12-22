using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	public class RepeatLimitConverter : fsDirectConverter<RepeatLimit>
	{
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RepeatLimit model)
		{
			return fsResult.Fail("Not implemented");
		}

		protected override fsResult DoSerialize(RepeatLimit model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<uint>(serialized, null, "low", model.low);
			base.SerializeMember<uint>(serialized, null, "high", model.high);
			base.SerializeMember<uint>(serialized, null, "repeat_limit", model.repeatLimit);
			return fsResult.Success;
		}
	}
}
