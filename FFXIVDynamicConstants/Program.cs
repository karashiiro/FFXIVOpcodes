using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace FFXIVDynamicConstants
{
    class Output
    {
        public Dictionary<string, object> Global;
        public Dictionary<string, object> CN;
        public Dictionary<string, object> KR;
    }

    class Program
    {
        static void Main(string[] _)
        {
            Console.WriteLine("Exporting...");

            var output = new Output
            {
                Global = Global.Constants,
                CN = CN.Constants,
                KR = KR.Constants,
            };

            var path1 = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "dynamic-constants.json");
            File.WriteAllText(path1, JsonConvert.SerializeObject(output, Formatting.Indented));

            var path2 = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "dynamic-constants.min.json");
            File.WriteAllText(path2, JsonConvert.SerializeObject(output));

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
