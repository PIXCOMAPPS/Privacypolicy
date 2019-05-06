using System;

using Foundation;
using UIKit;

namespace CMSDUBAI.iOS.viewcells
{
    public partial class AnalyticsreportCollectionViewCell1 : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("AnalyticsreportCollectionViewCell1");
        public static readonly UINib Nib;

        static AnalyticsreportCollectionViewCell1()
        {
            Nib = UINib.FromName("AnalyticsreportCollectionViewCell1", NSBundle.MainBundle);
        }

        protected AnalyticsreportCollectionViewCell1(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
