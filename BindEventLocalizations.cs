using System;
using System.Collections.Generic;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(BindEventLocalizationsConverter))]
	public class BindEventLocalizations
	{
		public Dictionary<string, string> AvailableLocalizations;
	}
}
