using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cliente
{
    // Rip mesenger 2010 F
    class Messenger
    {
        private static readonly HttpClient client = new HttpClient();

        public static async void Post(Object Data)
        {
            string Json = JsonConvert.SerializeObject(Data);

            var content = new (Json);

            var response = await client.PostAsync(Config.Url, content);

            var ResponseString = response.Content.Headers;

#if DEBUG
            Console.WriteLine("Debug:\r\n\tHeaders: " + ResponseString);
#endif
        }
    }
}
