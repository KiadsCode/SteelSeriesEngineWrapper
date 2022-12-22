using System;
using FullSerializer;
using SteelSeries.GameSense.DeviceZone;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(TactileHandlerConverter))]
	[Serializable]
	public class TactileHandler : AbstractHandler
	{
		public TactilePatternType TactilePatternType
		{
			get
			{
				return this._tactilePatternType;
			}
		}

		public RateMode RateMode
		{
			get
			{
				return this._rateMode;
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

		public TactilePatternRange pattern_range
		{
			get
			{
				return this.pattern as TactilePatternRange;
			}
			set
			{
				this.pattern = value;
				this._tactilePatternType = TactilePatternType.Range;
			}
		}

		public RateStatic rate_static
		{
			get
			{
				return this.rate as RateStatic;
			}
			set
			{
				this.rate = value;
				this._rateMode = RateMode.Static;
			}
		}

		public RateRange rate_range
		{
			get
			{
				return this.rate as RateRange;
			}
			set
			{
				this.rate = value;
				this._rateMode = RateMode.Range;
			}
		}

		private static TactileHandler _new()
		{
			return new TactileHandler();
		}

		private static TactileHandler Create(AbstractTactileDevice_Zone dz, TactileMode mode)
		{
			TactileHandler tactileHandler = TactileHandler._new();
			tactileHandler.deviceZone = dz;
			tactileHandler.mode = mode;
			return tactileHandler;
		}

		public static TactileHandler Create(AbstractTactileDevice_Zone dz, TactileMode mode, TactileEffectSimple[] pattern)
		{
			TactileHandler tactileHandler = TactileHandler.Create(dz, mode);
			tactileHandler.pattern_simple = TactilePatternSimple.Create(pattern);
			return tactileHandler;
		}

		public static TactileHandler Create(AbstractTactileDevice_Zone dz, TactileMode mode, TactileEffectCustom[] pattern)
		{
			TactileHandler tactileHandler = TactileHandler.Create(dz, mode);
			tactileHandler.pattern_custom = TactilePatternCustom.Create(pattern);
			return tactileHandler;
		}

		public static TactileHandler Create(AbstractTactileDevice_Zone dz, TactileMode mode, TactileEffectRange[] pattern)
		{
			TactileHandler tactileHandler = TactileHandler.Create(dz, mode);
			tactileHandler.pattern_range = TactilePatternRange.Create(pattern);
			return tactileHandler;
		}

		public static TactileHandler Create(AbstractTactileDevice_Zone dz, TactileMode mode, TactileEffectSimple[] pattern, RateStatic rate)
		{
			TactileHandler tactileHandler = TactileHandler.Create(dz, mode, pattern);
			tactileHandler.rate_static = rate;
			return tactileHandler;
		}

		public static TactileHandler Create(AbstractTactileDevice_Zone dz, TactileMode mode, TactileEffectCustom[] pattern, RateStatic rate)
		{
			TactileHandler tactileHandler = TactileHandler.Create(dz, mode, pattern);
			tactileHandler.rate_static = rate;
			return tactileHandler;
		}

		public static TactileHandler Create(AbstractTactileDevice_Zone dz, TactileMode mode, TactileEffectRange[] pattern, RateStatic rate)
		{
			TactileHandler tactileHandler = TactileHandler.Create(dz, mode, pattern);
			tactileHandler.rate_static = rate;
			return tactileHandler;
		}

		public static TactileHandler Create(AbstractTactileDevice_Zone dz, TactileMode mode, TactileEffectSimple[] pattern, RateRange rate)
		{
			TactileHandler tactileHandler = TactileHandler.Create(dz, mode, pattern);
			tactileHandler.rate_range = rate;
			return tactileHandler;
		}

		public static TactileHandler Create(AbstractTactileDevice_Zone dz, TactileMode mode, TactileEffectCustom[] pattern, RateRange rate)
		{
			TactileHandler tactileHandler = TactileHandler.Create(dz, mode, pattern);
			tactileHandler.rate_range = rate;
			return tactileHandler;
		}

		public static TactileHandler Create(AbstractTactileDevice_Zone dz, TactileMode mode, TactileEffectRange[] pattern, RateRange rate)
		{
			TactileHandler tactileHandler = TactileHandler.Create(dz, mode, pattern);
			tactileHandler.rate_range = rate;
			return tactileHandler;
		}

		private TactilePatternType _tactilePatternType;

		private RateMode _rateMode;

		public AbstractTactileDevice_Zone deviceZone;

		public TactileMode mode;

		public AbstractTactilePattern pattern;

		public AbstractRate rate;
	}
}
