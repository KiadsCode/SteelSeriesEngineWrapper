using System;

namespace SteelSeries.GameSense
{
	public class TactilePatternCustom : TactilePattern_Nonrecursive
	{
		public override TactilePatternType PatternType()
		{
			return TactilePatternType.Custom;
		}

		private static TactilePatternCustom _new()
		{
			return new TactilePatternCustom();
		}

		public static TactilePatternCustom Create(TactileEffectCustom[] effects)
		{
			TactilePatternCustom tactilePatternCustom = TactilePatternCustom._new();
			tactilePatternCustom.pattern = effects;
			return tactilePatternCustom;
		}

		public TactileEffectCustom[] pattern;
	}
}
