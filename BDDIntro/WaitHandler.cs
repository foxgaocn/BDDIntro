using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BDDIntro
{
	public class WaitHandler
	{
		public delegate bool WaitAction();

		/// <summary>
		/// Don't make this too large or small.  If you wait for 50 seconds then we want to poll about every 50 milliseconds.
		/// For example: over 50 seconds a value of 2000 will poll every 500 milliseconds.
		/// </summary>
		public const int DefaultTryTimes = 100;

		/// <summary>
		/// Polls quickly for short timeouts and less frequently for long operations.  This is ideal when waiting for long operations where 1 or more seconds do not matter.
		/// </summary>
		public static void WaitUntil(WaitAction action, string message, int timeOut = 10000, int tryTimes = DefaultTryTimes)
		{
			var waitingPeriod = timeOut / tryTimes;
			int triedTime = 0;
			while (triedTime < tryTimes)
			{
				if (action())
					return;
				Thread.Sleep(waitingPeriod);
				triedTime++;
			}
			throw new TimeoutException(message + " after waiting for " + timeOut + " millisecond");
		}

		/// <summary>
		/// Poll actively for action/event, even for long runnnig events.
		/// </summary>
		public static void WaitForTimeoutOrActionComplete(WaitAction action, string message, TimeSpan timeOut, bool throwException = true)
		{
			DateTime now = DateTime.Now;
			while (DateTime.Now - now < timeOut)
			{
				if (action())
					return;
				Thread.Sleep(50);
			}

			if (throwException)
				throw new TimeoutException("Failed to " + message + " after waiting for " + timeOut);
		}
	}
}
