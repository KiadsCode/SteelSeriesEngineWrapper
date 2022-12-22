using System;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(RateStaticConverter))]
	public class RateStatic : AbstractRate
	{
		private static RateStatic _new()
		{
			return new RateStatic();
		}

		public static RateStatic Create(uint frequency, uint repeatLimit = 0U)
		{
			RateStatic rateStatic = RateStatic._new();
			rateStatic.frequency = frequency;
			rateStatic.repeatLimit = repeatLimit;
			return rateStatic;
		}

		public uint frequency;

		public uint repeatLimit;
	}
}
