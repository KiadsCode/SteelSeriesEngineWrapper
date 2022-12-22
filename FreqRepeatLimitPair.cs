using System;

namespace SteelSeries.GameSense
{
	[Serializable]
	public struct FreqRepeatLimitPair
	{
		public FreqRepeatLimitPair(uint low, uint high, uint frequency, uint repeatLimit)
		{
			this.low = low;
			this.high = high;
			this.frequency = frequency;
			this.repeatLimit = repeatLimit;
		}

		public uint low;

		public uint high;

		public uint frequency;

		public uint repeatLimit;
	}
}
