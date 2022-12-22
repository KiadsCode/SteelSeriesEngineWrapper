using System;

namespace SteelSeries.GameSense
{
	[Serializable]
	public struct RGB
	{
		public RGB(byte r, byte g, byte b)
		{
			this.red = r;
			this.green = g;
			this.blue = b;
		}

		public byte red;

		public byte green;

		public byte blue;
	}
}
