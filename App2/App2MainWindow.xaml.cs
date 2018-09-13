﻿using System.Windows;

using App2.Resources;
using static App2.Constants;

//using SharedResources.Resources;

using static SharedProject1.SharedConstants;

// branch App2-SharedStringsViaLogicalName

// an alternate approach is to reference the shared
// resource project and link the resource files
// by it self it fails
// however, if the embed tag in the csproj
// file is adjusted to provide the
// logicalname tag and the correct
// logical name is provided, then it all works

// in this version, the shared resource designer
// file has its default namespace


namespace App2
{
	/// <summary>
	/// Interaction logic for App2MainWindow.xaml
	/// </summary>
	public partial class App2MainWindow : Window
	{
		

		public App2MainWindow()
		{
			InitializeComponent();

			// list who I am
			textBox1.Text = TellMeWhoIAm(WhoAmI() + NL);

			// use a shared routine from shared project
			// to say who I am
			textBox1.AppendText(
				SharedProject1.SharedProjectClass1.TellMeWhoIAm(PROJECTNAME) + NL);

			// use a local string run through a shared class
			textBox1.AppendText(
				SharedProject1.SharedProjectClass1.UseLocalString() + NL);

			// use a string from shared resources
			textBox1.AppendText("shared resource string :: >" +
				SharedResources.Resources.SharedStrings.WhoIAm + "<" + NL);

			// use a string from shared resources that is provided
			// by a routine in the shared project
			textBox1.AppendText(
				SharedProject1.SharedProjectClass1.UseSharedString() + NL);

			// use a string from local resources
			textBox1.AppendText("local resource string :: >" +
				App2.Resources.LocalString.LocalStringApp2 + "<" + NL);
		}


		// returns a local string
		public static string WhoAmI()
		{
			return LocalString.WhoIAm;
		}

		// local implementation 
		public static string TellMeWhoIAm(string who)
		{
			return "from " + PROJECTNAME
				+ "| I am " + who;

		}

	}
}

// this is how a local string or other value can be provided
// back to the shared project.  however, every referenced 
// project must have all of the same routines
namespace SharedProject1
{
	public class StringProvider
	{

		public static string LocalStringProvider()
		{
			return LocalString.WhoIAm;
		}
	}

}
