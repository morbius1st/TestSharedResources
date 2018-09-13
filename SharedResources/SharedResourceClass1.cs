using System;

namespace SharedResources
{
    public class SharedResourceClass1
	{
		

		static void Main()
		{
			Console.WriteLine(
				SharedProject1.SharedProjectClass1
				.TellMeWhoIAm(WhoAmI()));

			Console.WriteLine("Waiting");
			Console.ReadKey();
		}

		// returns who I am
		public static string WhoAmI()
		{
			return SharedProject1.Resources.SharedStrings.WhoIAm;
		}
	}
}

// this is here to prevent an unnecessary error
// of this routine not being found in all
// referenced projects
namespace SharedProject1
{
	public class StringProvider
	{

		public static string LocalStringProvider()
		{
			return null;
		}
	}

}