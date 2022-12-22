using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	internal class TactileEffectCustomConverter : fsDirectConverter<TactileEffectCustom>
	{
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref TactileEffectCustom model)
		{
			return fsResult.Fail("Not implemented");
		}

		protected override fsResult DoSerialize(TactileEffectCustom model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<string>(serialized, null, "type", "custom");
			base.SerializeMember<uint>(serialized, null, "length-ms", model.length_ms);
			base.SerializeMember<uint>(serialized, null, "delay-ms", model.delay_ms);
			return fsResult.Success;
		}
	}
}
