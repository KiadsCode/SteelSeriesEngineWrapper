using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	internal class RateStaticConverter : fsDirectConverter<RateStatic>
	{
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RateStatic model)
		{
			return fsResult.Fail("Not implemented");
		}

		protected override fsResult DoSerialize(RateStatic model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<uint>(serialized, null, "frequency", model.frequency);
			base.SerializeMember<uint>(serialized, null, "repeat_limit", model.repeatLimit);
			return fsResult.Success;
		}
	}
}
