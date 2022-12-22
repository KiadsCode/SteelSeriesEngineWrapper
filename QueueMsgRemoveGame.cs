using System;

namespace SteelSeries.GameSense
{
	public class QueueMsgRemoveGame : QueueMsg
	{
		public override Uri uri
		{
			get
			{
				return QueueMsgRemoveGame._uri;
			}
		}

		public override object data
		{
			get
			{
				return this._data as Game;
			}
			set
			{
				this._data = value;
			}
		}

		public override bool IsCritical()
		{
			return false;
		}

		public static Uri _uri;
	}
}
