using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2_Reflection_Software_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.ReadAttribute();
            Console.ReadKey();
        }
    }
}
