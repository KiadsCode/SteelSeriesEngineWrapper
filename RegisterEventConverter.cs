using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	public class RegisterEventConverter : fsDirectConverter<Register_Event>
	{
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Register_Event model)
		{
			return fsResult.Fail("Not implemented");
		}

		protected override fsResult DoSerialize(Register_Event model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<string>(serialized, null, "game", model.game.ToUpper());
			base.SerializeMember<string>(serialized, null, "event", model.eventName);
			base.SerializeMember<int>(serialized, null, "min_value", model.minValue);
			base.SerializeMember<int>(serialized, null, "max_value", model.maxValue);
			base.SerializeMember<uint>(serialized, null, "icon_id", (uint)model.iconId);
			return fsResult.Success;
		}
	}
}
