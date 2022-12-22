using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	public class RegisterGameConverter : fsDirectConverter<Register_Game>
	{
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Register_Game model)
		{
			return fsResult.Fail("Not implemented");
		}

		protected override fsResult DoSerialize(Register_Game model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<string>(serialized, null, "game", model.game);
			base.SerializeMember<string>(serialized, null, "game_display_name", model.game_display_name);
			base.SerializeMember<uint>(serialized, null, "icon_color_id", (uint)model.icon_color_id);
			return fsResult.Success;
		}
	}
}
