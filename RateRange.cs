using System;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(RateRangeConverter))]
	public class RateRange : AbstractRate
	{
		private static RateRange _new()
		{
			return new RateRange();
		}

		private static RateRange Create(uint size)
		{
			RateRange rateRange = RateRange._new();
			rateRange.frequency = new Frequency[size];
			rateRange.repeatLimit = new RepeatLimit[size];
			return rateRange;
		}

		public static RateRange Create(Frequency[] frequency, RepeatLimit[] repeatLimit = null)
		{
			RateRange rateRange = RateRange._new();
			rateRange.frequency = frequency;
			rateRange.repeatLimit = repeatLimit;
			return rateRange;
		}

		public static RateRange Create(FreqRepeatLimitPair[] pairs)
		{
			RateRange rateRange = RateRange.Create((uint)pairs.Length);
			uint num = 0U;
			foreach (FreqRepeatLimitPair freqRepeatLimitPair in pairs)
			{
				rateRange.frequency[(int)num].low = freqRepeatLimitPair.low;
				rateRange.frequency[(int)num].high = freqRepeatLimitPair.high;
				rateRange.frequency[(int)num].frequency = freqRepeatLimitPair.frequency;
				rateRange.repeatLimit[(int)num].low = freqRepeatLimitPair.low;
				rateRange.repeatLimit[(int)num].high = freqRepeatLimitPair.high;
				rateRange.repeatLimit[(int)num].repeatLimit = freqRepeatLimitPair.repeatLimit;
				num += 1U;
			}
			return rateRange;
		}

		public Frequency[] frequency;

		public RepeatLimit[] repeatLimit;
	}
}
