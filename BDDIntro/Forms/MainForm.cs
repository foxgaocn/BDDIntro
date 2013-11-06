using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;
using White.Core.UIItems;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WindowItems;

namespace BDDIntro.Forms
{
	public class MainForm
	{
		private Window window;
		public MainForm()
		{
			window = HuxleyApplication.app.GetWindow("MYOB AccountRight Standard");
			if (window == null)
			{
				throw new InvalidOperationException("Not ready yet");
			}
		}

		public UIItemContainer GetMdiWindowByAutomationId(string id)
		{
			UIItemContainer container = null;
			WaitHandler.WaitUntil(() =>
			{
				try
				{
					var ele = window.GetElement(SearchCriteria.ByAutomationId(id));
					container = new UIItemContainer(ele, HuxleyApplication.MainForm.window.ActionListener);
					return true;
				}
				catch (Exception e)
				{
					return false;
				}
			}, "cannot find element ");
			return container;
		}
	}
}
