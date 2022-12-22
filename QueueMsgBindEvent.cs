using System;

namespace SteelSeries.GameSense
{
	public class QueueMsgBindEvent : QueueMsg
	{
		public override Uri uri
		{
			get
			{
				return QueueMsgBindEvent._uri;
			}
		}

		public override object data
		{
			get
			{
				return this._data as Bind_Event;
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
