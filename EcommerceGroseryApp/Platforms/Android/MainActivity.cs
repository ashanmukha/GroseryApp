using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace EcommerceGroseryApp
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnStart()
        {
            base.OnStart();
            AppCenter.Start("android=dc739758-73cc-4948-9dd3-20dde4396c90" +
                  "uwp={Your UWP App secret here};" +
                  "ios=dc739758-73cc-4948-9dd3-20dde4396c90" +
                  "macos={Your macOS App secret here};",
                  typeof(Analytics), typeof(Crashes));
        }
    }
}
