﻿using System;
using System.Collections.Generic;
using FullSerializer;
using SteelSeries.GameSense.DeviceZone;

namespace SteelSeries.GameSense
{
	internal class TactileHandlerConverter : fsDirectConverter<TactileHandler>
	{
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref TactileHandler model)
		{
			return fsResult.Fail("Not implemented");
		}

		protected override fsResult DoSerialize(TactileHandler model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<string>(serialized, null, "device-type", model.deviceZone.device);
			base.SerializeMember<string>(serialized, null, "zone", ((AbstarctGenericTactile_Zone)model.deviceZone).zone);
			base.SerializeMember<TactileMode>(serialized, null, "mode", model.mode);
			switch (model.pattern.PatternType())
			{
			case TactilePatternType.Simple:
				base.SerializeMember<TactileEffectSimple[]>(serialized, null, "pattern", model.pattern_simple.pattern);
				break;
			case TactilePatternType.Custom:
				base.SerializeMember<TactileEffectCustom[]>(serialized, null, "pattern", model.pattern_custom.pattern);
				break;
			case TactilePatternType.Range:
				base.SerializeMember<TactileEffectRange[]>(serialized, null, "pattern", model.pattern_range.pattern);
				break;
			}
			RateMode rateMode = model.RateMode;
			if (rateMode != RateMode.Static)
			{
				if (rateMode == RateMode.Range)
				{
					base.SerializeMember<RateRange>(serialized, null, "rate", model.rate_range);
				}
			}
			else
			{
				base.SerializeMember<RateStatic>(serialized, null, "rate", model.rate_static);
			}
			return fsResult.Success;
		}
	}
}
