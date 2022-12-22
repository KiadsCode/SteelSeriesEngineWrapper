using System;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(TactileEffectSimpleConverter))]
	[Serializable]
	public class TactileEffectSimple
	{
		public TactileEffectSimple(TactileEffectType effect, uint delay = 0U)
		{
			this.type = effect;
			this.delay_ms = delay;
		}

		public TactileEffectType type;

		public uint delay_ms;
	}
}
