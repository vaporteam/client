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
        public static void Post(Object Data)
        {
            string Json = JsonConvert.SerializeObject(Data);

#if DEBUG
            Console.WriteLine("Debug:\r\n\tJson: " + Json);
#endif
            byte[] JsonBytes = Encoding.UTF8.GetBytes(Json);
             
            WebRequest request = HttpWebRequest.Create(Config.Url);
            request.ContentType = "application/json";
            request.Method = "POST";

            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(JsonBytes, 0, JsonBytes.Length);

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

        public string Get(Uri url)
        {
            var request = HttpWebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "GET";

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return responseString;
            }
            catch (WebException e)
            {
                return null;
            }
        }
    }

}
