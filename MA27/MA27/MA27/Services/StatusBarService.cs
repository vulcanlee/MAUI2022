using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Microsoft.Maui.Graphics.Color;
using Microsoft.Maui.Platform;

#if ANDROID
using Android.Views;
using Android.Graphics;
#elif IOS
using Foundation;
using UIKit;
#endif

namespace MA27.Services
{
    public class StatusBarService
    {
        public void ChangeBackgroundColor(Color color)
        {
#if ANDROID
            Android.Views.Window window = Platform.CurrentActivity.Window;
            window.ClearFlags(WindowManagerFlags.TranslucentStatus);
            window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);

            window.SetStatusBarColor(color.ToPlatform());
            //window.SetNavigationBarColor(color.ToPlatform());
#elif IOS
            UIView statusBar;
            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
            {
                int tag = 123; // Customize this tag as you want so we don't create it over and over
                UIWindow window = UIApplication.SharedApplication.Windows.FirstOrDefault();
                statusBar = window.ViewWithTag(tag);
                if (statusBar == null)
                {
                    statusBar = new UIView(UIApplication.SharedApplication.StatusBarFrame);
                    statusBar.Tag = tag;
                    statusBar.BackgroundColor = UIColor.Red; // Customize the view

                    window.AddSubview(statusBar);
                }
            }
            else
            {
                statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
            }

            statusBar.BackgroundColor = color.ToPlatform();
#else
#endif
        }
    }
}
