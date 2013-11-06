using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using BDDIntro.Forms;
using TechTalk.SpecFlow;

namespace BDDIntro.steps
{
	[Binding]
	public class LogonSteps
	{
		private SignOnForm signOnForm;

		[Given(@"I start AccountRight")]
		public void GivenIStartAccountRight()
		{
			HuxleyApplication.Start();
		}

		[Then(@"I should see the signon Window")]
		public void ThenIShouldSeeTheSignonWindow()
		{
			signOnForm = new SignOnForm();			
		}

		[When(@"I cancel sign on")]
		public void WhenICancelSignOn()
		{
			signOnForm.CancelButton.Click();
		}

		[Then(@"I should see the library browser")]
		public void ThenIShouldSeeTheLibraryBrowser()
		{
			
		}

	}
}
