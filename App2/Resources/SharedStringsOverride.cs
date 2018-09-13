#region + Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



#endregion


// projname: App2.Resources
// itemname: SharedStringsOverride
// username: jeffs
// created:  9/11/2018 10:50:39 PM


namespace App2.Resources
{
	public class SharedStrings : SharedResources.Resources.SharedStrings
	{
		private static global::System.Resources.ResourceManager resourceMan;

		public new static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(resourceMan, null))
				{
					global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("App2.Resources.SharedStrings", typeof(SharedStrings).Assembly);
					resourceMan = temp;
				}
				return resourceMan;
			}
		}

	}
}
