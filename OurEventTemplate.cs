using System;

namespace SteelSeries.GameSense
{
	public class OurEventTemplate
	{
		public OurEventTemplate(string upperCaseEventNameToUse)
		{
			this.upperCaseEventName = upperCaseEventNameToUse;
		}

		public string upperCaseEventName;

		public int minimumValue;

		public int maximumValue = 100;

		public EventIconId IconId;
	}
}
