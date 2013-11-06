using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using White.Core.UIItems;

namespace BDDIntro.Forms
{
	public class LibraryBrowserForm
	{
		private UIItemContainer win;
		public LibraryBrowserForm()
		{
			win = HuxleyApplication.MainForm.GetMdiWindowByAutomationId("Welcome");
		}

	}
}
