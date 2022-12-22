using System;

namespace SteelSeries.GameSense
{
	public class QueueMsgSendEvent : QueueMsg
	{
		public override Uri uri
		{
			get
			{
				return QueueMsgSendEvent._uri;
			}
		}

		public override object data
		{
			get
			{
				return this._data as Send_Event;
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
