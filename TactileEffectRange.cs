using System;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(TactileEffectRangeConverter))]
	[Serializable]
	public class TactileEffectRange
	{
		public TactilePatternType TactilePatternType
		{
			get
			{
				return this._tactilePatternType;
			}
		}

		public TactilePatternSimple pattern_simple
		{
			get
			{
				return this.pattern as TactilePatternSimple;
			}
			set
			{
				this.pattern = value;
				this._tactilePatternType = TactilePatternType.Simple;
			}
		}

		public TactilePatternCustom pattern_custom
		{
			get
			{
				return this.pattern as TactilePatternCustom;
			}
			set
			{
				this.pattern = value;
				this._tactilePatternType = TactilePatternType.Custom;
			}
		}

		private TactileEffectRange(uint low, uint high)
		{
			this.low = low;
			this.high = high;
			this._tactilePatternType = TactilePatternType.Simple;
			this.pattern = null;
		}

		public TactileEffectRange(uint low, uint high, TactileEffectSimple[] pattern) : this(low, high)
		{
			this.pattern_simple = TactilePatternSimple.Create(pattern);
		}

		public TactileEffectRange(uint low, uint high, TactileEffectCustom[] pattern) : this(low, high)
		{
			this.pattern_custom = TactilePatternCustom.Create(pattern);
		}

		private TactilePatternType _tactilePatternType;

		public uint low;

		public uint high;

		public TactilePattern_Nonrecursive pattern;
	}
}
