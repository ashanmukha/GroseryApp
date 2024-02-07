using CommunityToolkit.Maui;
using MauiEx;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.Extensions.Logging;

namespace EcommerceGroseryApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                 .UseMauiEx()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("iconic.ttf", "FontIcon");
                });
            AppCenter.Start("android=dc739758-73cc-4948-9dd3-20dde4396c90;" +
                  "ios=dc739758-73cc-4948-9dd3-20dde4396c90;" +
                  "macos={Your macOS App secret here};",
                  typeof(Analytics), typeof(Crashes));
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
