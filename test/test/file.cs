using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace test
{
    class file
    {
        public static bool FileCheck(string path)
        {
            bool resp = false;
            if (File.Exists(path))
                resp = true;
            else
                resp = false;
            return resp;
        }

        public static String ReadLine(string path)
        {
            string line; string[] lines;

            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path);
                line = lines[7] + lines[1];
            }

            else
                line = "";

            return line;
        }

        public static string ReadAll(string path)
        {
            string text;
            if (File.Exists(path))
            {
                text = File.ReadAllText(path);
            }
            else
                text = "Bitch, Blank Document";

            return text;
        }

        public static void Write(string path, string text)
        {
            if (File.Exists(path))
            {
                // text = File.WriteAllText();
            }
        }
    }
}
