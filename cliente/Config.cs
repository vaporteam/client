using Common;
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

        public static ClientConfig Cnf { get; set; } = LoadINI.TryLoad();

        class LoadConfig
        {
            public string ConfigEndpoint { get; } = "/config";

        }
           
        class LoadINI
        {
            public static ClientConfig TryLoad()
            {
                ClientConfig Cnf;
                if ((Cnf = LoadIni()) == null)
                {
                    if ((Cnf = CreateIni()) == null)
                    {
                        Console.WriteLine("Critical Error!\nCould not load config\nPress any key to exit...");
                        Console.ReadKey(false);
                        Environment.Exit(1);
                    }
                }
                return Cnf;
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

            private static ClientConfig LoadIni(bool failed = false)
            {
                ClientConfig Cnf = new ClientConfig();
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
                    Settings.Keys["Url"].TryParseValue(out string uri);
                    Cnf.Uri = uri;
                    //

                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }

#if DEBUG
            Console.WriteLine(
                "Debug: " + Environment.NewLine +
                "   Uri: " + Url + Environment.NewLine);
#endif
                return Cnf;
            }

            private static ClientConfig CreateIni()
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
                return LoadINI.LoadIni(failed: true);
            }
        }
    }
}
