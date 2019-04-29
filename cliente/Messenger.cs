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
        public static bool Post(Object Data)
        {
            string Json = JsonConvert.SerializeObject(Data);
#if DEBUG
            Console.WriteLine("Debug:\r\n\tJson: " + Json);
#endif
            // Create POST data and convert it to a byte array.  
            byte[] byteArray = Encoding.UTF8.GetBytes(Json);

            try
            {
                // Create a request using a URL that can receive a post.   
                WebRequest request = WebRequest.Create(Config.Url);
                // Set the Method property of the request to POST.  
                request.Method = "POST";



                // Set the ContentType property of the WebRequest.  
                request.ContentType = "application/json; charset=utf-8";
                // Set the ContentLength property of the WebRequest.  
                request.ContentLength = byteArray.Length;

                // Get the request stream.  
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.  
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.  
                dataStream.Close();

                // Get the response.  
                WebResponse response = request.GetResponse();
                // Display the status.  
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream containing content returned by the server.  
                // The using block ensures the stream is automatically closed.
                using (dataStream = response.GetResponseStream())
                {
                    // Open the stream using a StreamReader for easy access.  
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.  
                    string responseFromServer = reader.ReadToEnd();
                    // Display the content.  
                    Console.WriteLine(responseFromServer);
                }

                // Close the response.  
                response.Close();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
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
