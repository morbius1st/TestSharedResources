using System;
using Microsoft.VisualStudio.PlatformUI;
using SharedProject1;

using SharedResources.Resources;

namespace SharedResources
{
    public class SharedResourceClass1
	{
		static void Main()
		{
			Console.WriteLine(
				SharedProjectClass1
				.TellMeWhoIAm(SharedResourceClass2.WhoAmI()));

			Console.WriteLine("Waiting");
			Console.ReadKey();
		}

		
	}

}

namespace SharedProject1
{
	public class StringProvider
	{
		public static string LocalStringProvider()
		{
			return LocalStrings.WhoAmI;
		}
	}

}