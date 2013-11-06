using System.Diagnostics;
using System.Threading;
using BDDIntro.Forms;
using White.Core;
using White.Core.UIItems;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WPFUIItems;

namespace BDDIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			HuxleyApplication.Start();
			var signOnForm = new SignOnForm();
			signOnForm.CancelButton.Click();
		}
	}
}
