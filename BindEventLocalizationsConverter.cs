using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	public class BindEventLocalizationsConverter : fsDirectConverter<BindEventLocalizations>
	{
		protected override fsResult DoSerialize(BindEventLocalizations model, Dictionary<string, fsData> serialized)
		{
			foreach (KeyValuePair<string, string> keyValuePair in model.AvailableLocalizations)
			{
				base.SerializeMember<string>(serialized, null, keyValuePair.Key, keyValuePair.Value);
			}
			return fsResult.Success;
		}

		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref BindEventLocalizations model)
		{
			return fsResult.Fail("Not implemented");
		}
	}
}
