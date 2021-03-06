// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace Com.Bugsee
{
    [Register("BugseePrivateButton")]
    public class BugseePrivateButton : UIButton
    {
        public BugseePrivateButton(IntPtr handle) : base(handle)
        {
            this.BugseeProtectedView = true;
        }

        [Export("bugseeProtectedView")]
        public bool BugseeProtectedView { get; set; }
    }
}
