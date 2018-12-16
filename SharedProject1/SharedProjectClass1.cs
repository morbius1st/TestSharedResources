using System;
using SharedResources;
using static SharedProject1.SharedConstants;


namespace SharedProject1
{
	public class SharedProjectClass1
	{
		public string WhoAmI()
		{
			return "I am " + SHPROJECTNAME;
		}

		public static string TellMeWhoIAm(string who)
		{
			return "@ " + SHPROJECTNAME + "| I am " + who;
		}

		public static string UseSharedString()
		{
			return "@ " + SHPROJECTNAME + "| I am a shared string| " + SharedResources.Resources.SharedStrings.WhoIAm;
		}

		public static string UseLocalString()
		{
			return "@ " + SHPROJECTNAME + "| I am a local string| " +
				StringProvider.LocalStringProvider();
		}

	}

	public class SharedProjectClass2
	{
		public string UseSharedString2()
		{
			return "@ " + SHPROJECTNAME + "| I am a shared string| " + SharedResources.Resources.SharedStrings.WhoIAm;
		}
	}
}
