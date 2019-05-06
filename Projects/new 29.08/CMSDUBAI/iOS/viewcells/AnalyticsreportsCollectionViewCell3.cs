using System;

using Foundation;
using UIKit;

namespace CMSDUBAI.iOS.viewcells
{
    public partial class AnalyticsreportsCollectionViewCell3 : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("AnalyticsreportsCollectionViewCell3");
        public static readonly UINib Nib;

        static AnalyticsreportsCollectionViewCell3()
        {
            Nib = UINib.FromName("AnalyticsreportsCollectionViewCell3", NSBundle.MainBundle);
        }

        protected AnalyticsreportsCollectionViewCell3(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
