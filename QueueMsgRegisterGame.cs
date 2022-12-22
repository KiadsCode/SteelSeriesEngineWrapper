using System;

namespace SteelSeries.GameSense
{
	public class QueueMsgRegisterGame : QueueMsg
	{
		public override Uri uri
		{
			get
			{
				return QueueMsgRegisterGame._uri;
			}
		}

		public override object data
		{
			get
			{
				return this._data as Register_Game;
			}
			set
			{
				this._data = value;
			}
		}

		public override bool IsCritical()
		{
			return true;
		}

		public static Uri _uri;
	}
}
