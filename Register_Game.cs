using System;
using FullSerializer;

namespace SteelSeries.GameSense
{
	[fsObject(Converter = typeof(RegisterGameConverter))]
	public class Register_Game
	{
		public string game;

		public string game_display_name;

		public IconColor icon_color_id = IconColor.Green;
	}
}
