using System;

namespace SteelSeries.GameSense
{
	public class ColorGradient : AbstractColor_Nonrecursive
	{
		public override ColorEffect ColorEffectType()
		{
			return ColorEffect.Gradient;
		}

		private static ColorGradient _new()
		{
			return new ColorGradient();
		}

		public static ColorGradient Create(Gradient gradient)
		{
			ColorGradient colorGradient = ColorGradient._new();
			colorGradient.gradient = gradient;
			return colorGradient;
		}

		public static ColorGradient Create(RGB zero, RGB hundred)
		{
			ColorGradient colorGradient = ColorGradient._new();
			colorGradient.gradient = new Gradient(zero, hundred);
			return colorGradient;
		}

		public Gradient gradient;
	}
}
