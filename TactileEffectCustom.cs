using System;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(TactileEffectCustomConverter))]
	[Serializable]
	public class TactileEffectCustom
	{
		public TactileEffectCustom(uint length, uint delay = 0U)
		{
			this.length_ms = length;
			this.delay_ms = delay;
		}

		public const string type = "custom";

		public uint length_ms;

		public uint delay_ms;
	}
}
