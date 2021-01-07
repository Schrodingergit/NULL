using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_assign_unif
{
    //??=
    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = new int[11];

            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetArray();

            myArray ??= new int[0];

            Console.WriteLine("Amount of elem in array "+ myArray.Length);
        }
    }
}
