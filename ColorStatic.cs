using System;

namespace SteelSeries.GameSense
{
	public class ColorStatic : AbstractColor_Nonrecursive
	{
		public override ColorEffect ColorEffectType()
		{
			return ColorEffect.Static;
		}

		private static ColorStatic _new()
		{
			return new ColorStatic();
		}

		public static ColorStatic Create(byte r, byte g, byte b)
		{
			ColorStatic colorStatic = ColorStatic._new();
			colorStatic.red = r;
			colorStatic.green = g;
			colorStatic.blue = b;
			return colorStatic;
		}

		public byte red;

		public byte green;

		public byte blue;
	}
}
