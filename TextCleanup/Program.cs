using System;
using System.IO;
using System.Linq;
using System.Text;

namespace TextCleanup
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"C:\Users\aneso\Documents\GitHub\Novel-Writing-2019\data\Crime");

            string[] separatingChars = { "***" };

            for (int i = 0; i < files.Length; i++)
            {
                string text = "";
                string path = files[i];
                string name = path.Split('\\').LastOrDefault().Split('.').FirstOrDefault() + "_CLEANED" + ".txt";

                var n = Encoding.Default.GetString(File.ReadAllBytes(path))
                .Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries)
                .Select(d => d.Trim())
                .ToArray();

                text = n[2];

                File.WriteAllText(@"C:\Users\aneso\Documents\GitHub\Novel-Writing-2019\data\Crime\Cleaned\" + name, text);
            }
        }
    }
}
