using Microsoft.AppCenter.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGroseryApp.Helpers
{
    public static class EventTracker
    {
        public static void TrackEvent(string eventName,Dictionary<string,string> info = null)
        {
#if RELEASE
            try
            {
                if (info == null)
                {
                    info = new Dictionary<string,string>();
                }
                info.Add("Device Name",DeviceInfo.Name );
                info.Add("Manufacturer", DeviceInfo.Manufacturer);
                info.Add("Version", DeviceInfo.Version.ToString());
                info.Add("Ptatform",DeviceInfo.Platform.ToString());
                info.Add("AppVersion", VersionTracking.CurrentVersion.ToString());
                info.Add("TimeOffAction", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                Analytics.TrackEvent(eventName, info);
            }
            catch(Exception ex)
            {
                
            }
#endif
        }
    }
}
