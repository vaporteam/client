using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

#if DEBUG
            Console.WriteLine("Debug:\r\n\tJson: " + Json);
#endif

            WebRequest request = HttpWebRequest.Create(Config.Url);
            byte[] byteData = Encoding.ASCII.GetBytes(Json);
            request.ContentType = "application/json";
            request.Method = "POST";

            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(byteData, 0, byteData.Length);
                }
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

#if DEBUG
                Console.WriteLine("Debug:\r\n\tResponse: " + responseString);
#endif
            }
            catch (WebException e)
            {
                Console.WriteLine("Error:\r\n\t " + e.Message);
            }
        }
    }
}
