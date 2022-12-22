using System;

namespace SteelSeries.GameSense
{
	public class TactilePatternRange : AbstractTactilePattern
	{
		public override TactilePatternType PatternType()
		{
			return TactilePatternType.Range;
		}

		private static TactilePatternRange _new()
		{
			return new TactilePatternRange();
		}

		public static TactilePatternRange Create(TactileEffectRange[] effects)
		{
			TactilePatternRange tactilePatternRange = TactilePatternRange._new();
			tactilePatternRange.pattern = effects;
			return tactilePatternRange;
		}

		public TactileEffectRange[] pattern;
	}
}
