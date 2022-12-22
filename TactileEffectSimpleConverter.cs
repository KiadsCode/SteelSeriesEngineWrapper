using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	internal class TactileEffectSimpleConverter : fsDirectConverter<TactileEffectSimple>
	{
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref TactileEffectSimple model)
		{
			return fsResult.Fail("Not implemented");
		}

		protected override fsResult DoSerialize(TactileEffectSimple model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<TactileEffectType>(serialized, null, "type", model.type);
			base.SerializeMember<uint>(serialized, null, "delay-ms", model.delay_ms);
			return fsResult.Success;
		}
	}
}
