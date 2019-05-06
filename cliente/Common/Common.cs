using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Status
    {
        public string Id { get; set; }
        public string Time { get; set; }
        public string Stat { get; set; }
        public string Description { get; set; }
    }

    public class ClientConfig
    {
        public int ActivityTimeout { get; set; } = Duration.Minute * 15; // 15 Minutos
        public int InputCheckRate { get; set; } = Duration.Minute * 5; // 5 Min
        public string Uri { get; set; } = "";
    }

    public static class Duration
    {
        public static int Second { get; } = 1000;
        public static int Minute { get; } = Second * 60;
        public static int Hour { get; } = Minute * 60;
    }

    public static class Utils
    {
        public static byte[] ExtractResource(Assembly assembly, string resourceName)
        {
            if (assembly == null)
            {
                return null;
            }

            using (Stream resFilestream = assembly.GetManifestResourceStream(resourceName))
            {
                if (resFilestream == null)
                {
                    return null;
                }

                byte[] bytes = new byte[resFilestream.Length];
                resFilestream.Read(bytes, 0, bytes.Length);

                return bytes;
            }
        }
    }
}
