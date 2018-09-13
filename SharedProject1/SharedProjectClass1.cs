using System;

namespace SharedProject1
{
	public class SharedProjectClass1
	{
		public string WhoAmI()
		{
			return "I am SharedProject1";
		}

		public static string TellMeWhoIAm(string who)
		{
			return "@ shared project| I am " + who;

		}

		public static string UseSharedString()
		{
			return "@ shared project| " + SharedResources.Resources.SharedStrings.WhoIAm;
		}

		public static string UseLocalString()
		{
			return "@ shared project| I am a local string| " +
				SharedProject1.StringProvider.LocalStringProvider();
		}

	}
}
