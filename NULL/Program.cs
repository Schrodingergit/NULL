using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NULL
{
    class MyClass
    {

    }
    struct MyStruct
    {

    }
    class Program
    {
        static void Foo()
        {
            int b;//after leaving method "Foo()" b will get removed from stack

            int[] a = new int[10];//removes reference but keeps the data heap until garbage collector takes action(memory leak in C++)
        }
        static void Main(string[] args)
        {
            bool b;//false

            int a;//

            double d;//0

            Random random;//null

            int[] arr;//null

            arr = new int[10];//using operator "new" alocate memory to array in a heap and returns reference data located in variable arr

            arr = null;//removes connections with variable "arr" on stack and with data in the heap, it keeps them there not removes them(in c++ it would be a memory leak, but in c# we have garbage collector)

            MyClass myClass;//null

            MyStruct myStruct;//(project name)->NULL.MyStruct - default 
        }
    }
}
