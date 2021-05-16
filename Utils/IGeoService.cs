using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace Filters.Utils
{
    public interface IGeoService
    {
        Task<string> GetCountry(string ipAddress);
    }
    public class GeoService : IGeoService
    {//fa604021e9fdc4487be77f294b5a26ee
        public async Task<string> GetCountry(string ipAddress)
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync($"http://api.ipstack.com/${ipAddress}?access_key=<your api key>");
                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                return data.ip;
            }
        }
    }
}
