using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA17.Services
{
    public partial class WhichPlatformService
    {
        public partial async Task<string> GetPlatformName()
        {
            // 故意模擬非同步作業，要 1 秒鐘的時間
            await Task.Delay(1000);
            return "iOS";
        }

    }
}
