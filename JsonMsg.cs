using System;

namespace SteelSeries.GameSense
{
	
	public class JsonMsg : QueueMsg
	{
		public override Uri uri
		{
			get
			{
				return QueueMsgSendEvent._uri;
			}
		}

		public override object data { get; set; }

		public string JsonText { get; set; }

		public override bool IsCritical()
		{

			return false;
		}

		public static Uri _bitmapEventUri;
	}
}
