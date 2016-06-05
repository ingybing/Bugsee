using System;

using UIKit;
using Foundation;

using Com.Bugsee;

namespace BugseeTest
{
	public partial class ViewController : UIViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void TapToCrashTouchUpInside(NSObject sender)
		{
			throw new System.NotImplementedException();
		}

        partial void ShowReportControllerTapUpInside(NSObject sender)
        {
            Com.Bugsee.Bugsee.ShowReportController();
        }

        partial void PauseRecordingTapUpInside(NSObject sender)
        {
            Com.Bugsee.Bugsee.Pause();
        }

        partial void ResumeRecordingTouchUpInside(NSObject sender)
        {
            Com.Bugsee.Bugsee.Resume();
        }
	}
}

