using MA16.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA16.Services
{
    public class WhichPlatformService : IWhichPlatform
    {
        public async Task<string> GetPlatformName()
        {
            // 故意模擬非同步作業，要 1 秒鐘的時間
            await Task.Delay(1000);

#if ANDROID
            return "Android";
#elif IOS
            return "iOS";
#elif WINDOWS
            return "WinUI3";
#elif MACCATALYST
            return "MacCatalyst";
#else
            return "Unknow";
#endif
        }
    }
}
