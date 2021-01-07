using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_coalescing
{
    // ??
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            string result = str ?? string.Empty;
            
            //Console.WriteLine(str ?? "No Data");
            Console.WriteLine("Length of string" + str.Length);
        }
    }
}
