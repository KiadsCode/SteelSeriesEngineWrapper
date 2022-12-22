using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	internal class TactileEffectRangeConverter : fsDirectConverter<TactileEffectRange>
	{
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref TactileEffectRange model)
		{
			return fsResult.Fail("Not implemented");
		}

		protected override fsResult DoSerialize(TactileEffectRange model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<uint>(serialized, null, "low", model.low);
			base.SerializeMember<uint>(serialized, null, "high", model.high);
			TactilePatternType tactilePatternType = model.TactilePatternType;
			if (tactilePatternType != TactilePatternType.Simple)
			{
				if (tactilePatternType == TactilePatternType.Custom)
				{
					base.SerializeMember<TactileEffectCustom[]>(serialized, null, "pattern", model.pattern_custom.pattern);
				}
			}
			else
			{
				base.SerializeMember<TactileEffectSimple[]>(serialized, null, "pattern", model.pattern_simple.pattern);
			}
			return fsResult.Success;
		}
	}
}
