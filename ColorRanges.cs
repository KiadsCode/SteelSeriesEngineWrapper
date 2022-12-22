using System;

namespace SteelSeries.GameSense
{
	public class ColorRanges : AbstractColor
	{
		public override ColorEffect ColorEffectType()
		{
			return ColorEffect.Range;
		}

		private static ColorRanges _new()
		{
			return new ColorRanges();
		}

		public static ColorRanges Create(ColorRange[] ranges)
		{
			ColorRanges colorRanges = ColorRanges._new();
			colorRanges.ranges = ranges;
			return colorRanges;
		}

		public ColorRange[] ranges;
	}
}
