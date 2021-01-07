using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_conditional
{
    //?.
    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = { 1, 2, 3 };//if null, NullExeption
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();

            Console.WriteLine("Sum of elem in array " + (myArray?.Sum() ?? 0));//?. If Null, null will stay, will not procces Sum, ?? default value shown
        }
    }
}
