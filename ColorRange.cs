using System;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(ColorRangeConverter))]
	[Serializable]
	public class ColorRange
	{
		public RangeColorEffect ColorEffect
		{
			get
			{
				return this._effect;
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
				this._effect = RangeColorEffect.Static;
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
				this._effect = RangeColorEffect.Gradient;
			}
		}

		public ColorRange(uint low, uint high, ColorStatic color)
		{
			this.low = low;
			this.high = high;
			this.color_static = color;
		}

		public ColorRange(uint low, uint high, ColorGradient color)
		{
			this.low = low;
			this.high = high;
			this.color_gradient = color;
		}

		public ColorRange(uint low, uint high, RGB zero, RGB hundred)
		{
			this.low = low;
			this.high = high;
			this.color_gradient = ColorGradient.Create(zero, hundred);
		}

		private RangeColorEffect _effect;

		public uint low;

		public uint high;

		public AbstractColor_Nonrecursive color;
	}
}
