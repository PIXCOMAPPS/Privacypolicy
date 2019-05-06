using System;

using Foundation;
using UIKit;

namespace CMSDUBAI.iOS.viewcells
{
    public partial class AnalyticsreportsCollectionViewCell2 : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("AnalyticsreportsCollectionViewCell2");
        public static readonly UINib Nib;

        static AnalyticsreportsCollectionViewCell2()
        {
            Nib = UINib.FromName("AnalyticsreportsCollectionViewCell2", NSBundle.MainBundle);
        }

        protected AnalyticsreportsCollectionViewCell2(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
