using MadMilkman.Ini;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente
{
    static class Config
    {
        private static string iniPath = string.Format("{0}\\{1}", Directory.GetCurrentDirectory(), "settings.ini");
        public static string Url { get; set; } = "http://localhost:8080";

        public static Common.ClientConfig Cnf { get; set; } = new Common.ClientConfig();

        class LoadConfig
        {
            public string ConfigEndpoint { get; } = "/config";

        }
           
        class LoadINI
        {
            public static void TryLoad()
            {
                if (!LoadIni())
                {
                    if (!CreateIni())
                    {
                        Console.WriteLine("Critical Error!\nCould not load config\nPress any key to exit...");
                        Console.ReadKey(false);
                        Environment.Exit(1);
                        if (!LoadIni())
                        {

                        }
                    }
                }
            }

            private static IniOptions IniOptions()
            {
                IniOptions options = new IniOptions();
                options.CommentStarter = IniCommentStarter.Hash;
                options.Compression = false;
                options.Encoding = Encoding.UTF8;
                options.EncryptionPassword = null;
                return options;
            }

            private static bool LoadIni()
            {
                try
                {
                    IniFile file = new IniFile(IniOptions());
                    file.Load(iniPath);

                    // Map 'yes' value as 'true' boolean.
                    file.ValueMappings.Add("yes", true);
                    file.ValueMappings.Add("true", true);
                    file.ValueMappings.Add("1", true);
                    // Map 'no' value as 'false' boolean.
                    file.ValueMappings.Add("no", false);
                    file.ValueMappings.Add("false", false);
                    file.ValueMappings.Add("0", false);

                    //IniSection Debug = file.Sections["Debug"];
                    //
                    //Debug.Keys["DebugToConsole"].TryParseValue(out DebugToConsole);
                    //
                    IniSection Settings = file.Sections["Client"];
                    //
                    string uri;
                    Settings.Keys["Url"].TryParseValue(out uri);
                    Url = uri;
                    //

                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }

#if DEBUG
            Console.WriteLine(
                "Debug: " + Environment.NewLine +
                "   Uri: " + Url + Environment.NewLine);
#endif
                return true;
            }

            private static bool CreateIni()
            {
                int Indentation = 4;
                // Create new file with a default formatting.
                IniFile file = new IniFile(IniOptions());

                //
                IniSection Settings = file.Sections.Add("Client");
                Settings.TrailingComment.Text = "Client Settings \\:D/";
                //

                IniKey Rows = Settings.Keys.Add("Url", Url);
                Rows.LeftIndentation = Indentation;
                Rows.TrailingComment.Text = "This is where the software will send requests";
                Rows.TrailingComment.LeftIndentation = Indentation;
                // Save file.
                try
                {
                    file.Save(iniPath);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                return true;
            }
        }
    }
}
