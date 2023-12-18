using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;

namespace TestCode
{
    class MyDownloadString
    {
        Stopwatch sw = new Stopwatch();

        public void DoRun()
        {
            const int LargeNumber = 6_000_000;
            sw.Start();
        }

        private int CountCharacters(int id,string uriString)
        {
            WebClient wc1 = new WebClient();
            Console.WriteLine("Starting call {0}:{1,4:No}ms",
                id,sw.Elapsed.TotalSeconds);
            return 0;
        }
    }
}
