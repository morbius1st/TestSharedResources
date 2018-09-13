using System.Windows;

using App3.Resources;
using static App3.Constants;

using static SharedProject1.SharedConstants;

// step 1
// initial setup of app 3 that uses shared resources
// but the csproj file has not been modified
// step 2
//  the csproj file has been modified to add
// the logicalname tag that "corrects" the
// name of the resource within the assembly



namespace App3
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			// list who I am
			textBox1.Text = TellMeWhoIAm(WhoAmI()) + NL;

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
				App3.Resources.LocalString.LocalStringApp3 + "<" + NL);
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
