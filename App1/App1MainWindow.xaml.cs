using System;
using System.Windows;
using App1.Resources;

using static SharedProject1.SharedConstants;


// this example uses the sharedresources project - this is not a shared project
// and the sharedproject1 project - this is a shared project
// this uses the resx defined in the shared resources
// this uses the xaml dialog box in shared resources
// this uses code defined in the shared project


namespace App1
{
	
	/// <summary>
	/// Interaction logic for App1MainWindow.xaml
	/// </summary>
	public partial class App1MainWindow : Window
	{

		private const string PROJECTNAME = "App1";

		public App1MainWindow()
		{
			InitializeComponent();

			// list who I am
			textBox1.Text = TellMeWhoIAm(WhoAmI());

			// use a shared routine from shared project
			// to say who I am
			textBox1.AppendText(
				SharedProject1.SharedProjectClass1.TellMeWhoIAm(PROJECTNAME) + NL);
			
			// use a local string run through a shared project
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
				App1.Resources.LocalString.LocalStringApp1 + "<" + NL);

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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void Dialog_OnClick(object sender, RoutedEventArgs e)
		{
			(new SharedResources.SharedDialogBox()).ShowDialog();
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
