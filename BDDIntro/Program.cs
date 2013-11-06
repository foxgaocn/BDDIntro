using System.Diagnostics;
using System.Threading;
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
			var processInfo = new ProcessStartInfo(@"C:\projects\main\Build_Output\Debug\Huxley.Application.exe", "-f myob-ar://localhost:6962/Default/_tmp/BDDTest.myox");
			var app = Application.Launch(processInfo);
			Thread.Sleep(10000);
			var mainWindow = app.GetWindow("MYOB AccountRight Standard");
			var signOnWindow = new UIItem(mainWindow.GetElement(SearchCriteria.ByAutomationId("UserLogin")), mainWindow.ActionListener); 
			
			var cancelButton = signOnWindow.Get(SearchCriteria.ByAutomationId("btnCancel"));
			cancelButton.Click();
		}
	}
}
