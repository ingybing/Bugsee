// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace Com.Bugsee
{
    [Register("BugseePrivatePickerView")]
    public class BugseePrivatePickerView : UIPickerView
    {
        public BugseePrivatePickerView(IntPtr handle) : base(handle)
        {
            this.BugseeProtectedView = true;
        }

        [Export("bugseeProtectedView")]
        public bool BugseeProtectedView { get; set; }
    }
}
