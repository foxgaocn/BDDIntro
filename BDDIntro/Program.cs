using System.Diagnostics;
using System.Threading;
using System.Windows.Automation;
using System.Windows.Input;
using White.Core.InputDevices;
using White.Core.UIItems;

namespace BDDIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			var process = Process.Start(@"C:\projects\main\Build_Output\Debug\Huxley.Application.exe", "-f myob-ar://localhost:6962/Default/_tmp/BDDTest.myox");
			Thread.Sleep(10000);
			
			var mainWindow = AutomationElement.FromHandle(process.MainWindowHandle);
			
			var signOnWindow = mainWindow.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.AutomationIdProperty, "UserLogin"));
			
			var cancelButton = signOnWindow.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.AutomationIdProperty, "btnCancel"));
			
			Mouse.Instance.Click(cancelButton.Current.BoundingRectangle.TopLeft);
		}
	}
}
