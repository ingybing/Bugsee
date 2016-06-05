// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace Com.Bugsee
{
    [Register("BugseePrivateCollectionView")]
    public class BugseePrivateCollectionView : UICollectionView
    {
        public BugseePrivateCollectionView(IntPtr handle) : base(handle)
        {
            this.BugseeProtectedView = true;
        }

        [Export("bugseeProtectedView")]
        public bool BugseeProtectedView { get; set; }
    }
}
