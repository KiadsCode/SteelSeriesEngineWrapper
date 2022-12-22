using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	public class SendEventConverter : fsDirectConverter<Send_Event>
	{
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Send_Event model)
		{
			return fsResult.Fail("Not implemented");
		}

		protected override fsResult DoSerialize(Send_Event model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<string>(serialized, null, "game", model.game);
			base.SerializeMember<string>(serialized, null, "event", model.event_name);
			base.SerializeMember<EventData>(serialized, null, "data", model.data);
			return fsResult.Success;
		}
	}
}
