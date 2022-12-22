using System;

namespace SteelSeries.GameSense
{
	[Serializable]
	public struct Frequency
	{
		public Frequency(uint low, uint high, uint frequency)
		{
			this.low = low;
			this.high = high;
			this.frequency = frequency;
		}

		public uint low;

		public uint high;

		public uint frequency;
	}
}
