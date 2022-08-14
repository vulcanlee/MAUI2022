using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA18.Services
{
    public class AddService
    {
        public async Task<string> AddValues(int value1, int value2)
        {
            string endPoint = $"https://lobworkshop.azurewebsites.net/api/RemoteSource/Add/{value1}/{value2}/3";
            string reslut = await new HttpClient().GetStringAsync(endPoint);
            return reslut;
        }
    }
}
