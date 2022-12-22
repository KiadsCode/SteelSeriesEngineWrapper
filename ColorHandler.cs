using System;
using FullSerializer;
using SteelSeries.GameSense.DeviceZone;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(ColorHandlerConverter))]
	public class ColorHandler : AbstractHandler
	{
		public ColorEffect ColorEffect
		{
			get
			{
				return this._colorEffect;
			}
		}

		public RateMode RateMode
		{
			get
			{
				return this._rateMode;
			}
		}

		public ColorStatic color_static
		{
			get
			{
				return this.color as ColorStatic;
			}
			set
			{
				this.color = value;
				this._colorEffect = ColorEffect.Static;
			}
		}

		public ColorGradient color_gradient
		{
			get
			{
				return this.color as ColorGradient;
			}
			set
			{
				this.color = value;
				this._colorEffect = ColorEffect.Gradient;
			}
		}

		public ColorRanges color_range
		{
			get
			{
				return this.color as ColorRanges;
			}
			set
			{
				this.color = value;
				this._colorEffect = ColorEffect.Range;
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

		private static ColorHandler _new()
		{
			return new ColorHandler();
		}

		private static ColorHandler Create(AbstractIlluminationDevice_Zone dz, IlluminationMode mode)
		{
			ColorHandler colorHandler = ColorHandler._new();
			colorHandler.deviceZone = dz;
			colorHandler.mode = mode;
			colorHandler._rateMode = RateMode.None;
			return colorHandler;
		}

		public static ColorHandler Create(AbstractIlluminationDevice_Zone dz, IlluminationMode mode, ColorStatic color)
		{
			ColorHandler colorHandler = ColorHandler.Create(dz, mode);
			colorHandler.color_static = color;
			return colorHandler;
		}

		public static ColorHandler Create(AbstractIlluminationDevice_Zone dz, IlluminationMode mode, ColorStatic color, RateStatic rate)
		{
			ColorHandler colorHandler = ColorHandler.Create(dz, mode);
			colorHandler.color_static = color;
			colorHandler.rate_static = rate;
			return colorHandler;
		}

		public static ColorHandler Create(AbstractIlluminationDevice_Zone dz, IlluminationMode mode, ColorStatic color, RateRange rate)
		{
			ColorHandler colorHandler = ColorHandler.Create(dz, mode);
			colorHandler.color_static = color;
			colorHandler.rate_range = rate;
			return colorHandler;
		}

		public static ColorHandler Create(AbstractIlluminationDevice_Zone dz, IlluminationMode mode, ColorGradient color)
		{
			ColorHandler colorHandler = ColorHandler.Create(dz, mode);
			colorHandler.color_gradient = color;
			return colorHandler;
		}

		public static ColorHandler Create(AbstractIlluminationDevice_Zone dz, IlluminationMode mode, ColorGradient color, RateStatic rate)
		{
			ColorHandler colorHandler = ColorHandler.Create(dz, mode);
			colorHandler.color_gradient = color;
			colorHandler.rate_static = rate;
			return colorHandler;
		}

		public static ColorHandler Create(AbstractIlluminationDevice_Zone dz, IlluminationMode mode, ColorGradient color, RateRange rate)
		{
			ColorHandler colorHandler = ColorHandler.Create(dz, mode);
			colorHandler.color_gradient = color;
			colorHandler.rate_range = rate;
			return colorHandler;
		}

		public static ColorHandler Create(AbstractIlluminationDevice_Zone dz, IlluminationMode mode, ColorRanges color)
		{
			ColorHandler colorHandler = ColorHandler.Create(dz, mode);
			colorHandler.color_range = color;
			return colorHandler;
		}

		public static ColorHandler Create(AbstractIlluminationDevice_Zone dz, IlluminationMode mode, ColorRanges color, RateStatic rate)
		{
			ColorHandler colorHandler = ColorHandler.Create(dz, mode);
			colorHandler.color_range = color;
			colorHandler.rate_static = rate;
			return colorHandler;
		}

		public static ColorHandler Create(AbstractIlluminationDevice_Zone dz, IlluminationMode mode, ColorRanges color, RateRange rate)
		{
			ColorHandler colorHandler = ColorHandler.Create(dz, mode);
			colorHandler.color_range = color;
			colorHandler.rate_range = rate;
			return colorHandler;
		}

		private ColorEffect _colorEffect;

		private RateMode _rateMode;

		public AbstractIlluminationDevice_Zone deviceZone;

		public IlluminationMode mode;

		public AbstractColor color;

		public AbstractRate rate;
	}
}
