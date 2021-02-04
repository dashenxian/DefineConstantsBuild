using System;
using System.Collections.Generic;
#if LabA
using LabA;
#elif LabB
using LabB;
#endif

namespace DefineConstantsBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = Class1.Add(1, 2);
            Console.ReadKey();
        }
    }
}
