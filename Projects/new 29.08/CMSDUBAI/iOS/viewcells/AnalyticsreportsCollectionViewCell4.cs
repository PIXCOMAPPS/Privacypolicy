using System;

using Foundation;
using UIKit;

namespace CMSDUBAI.iOS.viewcells
{
    public partial class AnalyticsreportsCollectionViewCell4 : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("AnalyticsreportsCollectionViewCell4");
        public static readonly UINib Nib;

        static AnalyticsreportsCollectionViewCell4()
        {
            Nib = UINib.FromName("AnalyticsreportsCollectionViewCell4", NSBundle.MainBundle);
        }

        protected AnalyticsreportsCollectionViewCell4(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
