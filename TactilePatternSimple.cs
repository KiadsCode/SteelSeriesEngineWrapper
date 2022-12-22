using System;

namespace SteelSeries.GameSense
{
	public class TactilePatternSimple : TactilePattern_Nonrecursive
	{
		public override TactilePatternType PatternType()
		{
			return TactilePatternType.Simple;
		}

		private static TactilePatternSimple _new()
		{
			return new TactilePatternSimple();
		}

		public static TactilePatternSimple Create(TactileEffectSimple[] effects)
		{
			TactilePatternSimple tactilePatternSimple = TactilePatternSimple._new();
			tactilePatternSimple.pattern = effects;
			return tactilePatternSimple;
		}

		public TactileEffectSimple[] pattern;
	}
}
