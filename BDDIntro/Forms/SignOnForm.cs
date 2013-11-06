using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using White.Core.UIItems;

namespace BDDIntro.Forms
{
	public class SignOnForm
	{
		private UIItemContainer win;
		public SignOnForm()
		{
			win = HuxleyApplication.MainForm.GetMdiWindowByAutomationId("UserLogin");
		}

		public Button CancelButton
		{
			get
			{
				return win.Get<Button>("btnCancel");
			}
		}
	}
}
