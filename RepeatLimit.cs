using System;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(RepeatLimitConverter))]
	[Serializable]
	public struct RepeatLimit
	{
		public RepeatLimit(uint low, uint high, uint repeatLimit)
		{
			this.low = low;
			this.high = high;
			this.repeatLimit = repeatLimit;
		}

		public uint low;

		public uint high;

		public uint repeatLimit;
	}
}
