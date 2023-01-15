using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Q_1_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting the current executing assembly
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            // Getting current Example class in Assembly
            Type T = executingAssembly.GetType("Q_1_Reflection.Example");
            object exampleInstance = Activator.CreateInstance(T);

            MethodInfo meth_info = T.GetMethod("add");
            string[] str = new string[2];
            str[0] = "5";
            str[1] = "3";

            Console.WriteLine("Type: " + T);

            Console.WriteLine("-----Methods-----");
            MethodInfo[] methods = T.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            int res = (int)meth_info.Invoke(exampleInstance, str);
            Console.WriteLine($"Result = {res}");

            Console.ReadKey();
        }
    }
}
