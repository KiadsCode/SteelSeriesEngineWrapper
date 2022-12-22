using System;

namespace SteelSeries.GameSense
{
	[Serializable]
	public struct Gradient
	{
		public Gradient(RGB zero, RGB hundred)
		{
			this.zero = zero;
			this.hundred = hundred;
		}

		public Gradient(byte r0, byte g0, byte b0, byte r1, byte g1, byte b1)
		{
			this.zero = new RGB(r0, g0, b0);
			this.hundred = new RGB(r1, g1, b1);
		}

		public RGB zero;

		public RGB hundred;
	}
}
