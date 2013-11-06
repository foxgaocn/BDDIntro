using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using BDDIntro.Forms;
using White.Core;

namespace BDDIntro
{
	public class HuxleyApplication
	{
		internal static Application app;
		private static MainForm _mainForm;

		public static void Start()
		{
			var processInfo = new ProcessStartInfo(@"C:\projects\main\Build_Output\Debug\Huxley.Application.exe", "-f myob-ar://localhost:6962/Default/_tmp/BDDTest.myox");
			app = Application.Launch(processInfo);
		}

		public static void Stop()
		{
			app.Kill();
		}

		public static MainForm MainForm
		{
			get
			{
				if (_mainForm == null)
				{
					WaitHandler.WaitUntil(TryGetMainWindow, "Cannot get main window");
				}
				return _mainForm;
			}
		}

		private static bool TryGetMainWindow()
		{
			try
			{
				_mainForm = new MainForm();
				return true;
			}
			catch (Exception e)
			{
				return false;
			}
		}
	}
}

