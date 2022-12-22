using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	public class BindEventConverter : fsDirectConverter<Bind_Event>
	{
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bind_Event model)
		{
			return fsResult.Fail("Not implemented");
		}

		protected override fsResult DoSerialize(Bind_Event model, Dictionary<string, fsData> serialized)
		{
			base.SerializeMember<string>(serialized, null, "game", model.game.ToUpper());
			base.SerializeMember<string>(serialized, null, "event", model.eventName);
			base.SerializeMember<int>(serialized, null, "min_value", model.minValue);
			base.SerializeMember<int>(serialized, null, "max_value", model.maxValue);
			base.SerializeMember<uint>(serialized, null, "icon_id", (uint)model.iconId);
			base.SerializeMember<AbstractHandler[]>(serialized, null, "handlers", model.handlers);
			if (model.defaultDisplayName != null)
			{
				base.SerializeMember<string>(serialized, null, "default_display_name", model.defaultDisplayName);
			}
			if (model.localizedDisplayNames != null)
			{
				BindEventLocalizations value = new BindEventLocalizations
				{
					AvailableLocalizations = model.localizedDisplayNames
				};
				base.SerializeMember<BindEventLocalizations>(serialized, null, "localized_display_names", value);
			}
			return fsResult.Success;
		}
	}
}
