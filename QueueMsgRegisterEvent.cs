using System;

namespace SteelSeries.GameSense
{
	public class QueueMsgRegisterEvent : QueueMsg
	{
		public override Uri uri
		{
			get
			{
				return QueueMsgRegisterEvent._uri;
			}
		}

		public override object data
		{
			get
			{
				return this._data as Register_Event;
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
