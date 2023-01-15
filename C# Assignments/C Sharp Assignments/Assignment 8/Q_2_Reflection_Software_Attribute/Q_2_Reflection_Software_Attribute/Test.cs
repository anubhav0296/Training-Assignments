using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Q_2_Reflection_Software_Attribute
{
    public class Test
    {
        public void ReadAttribute()
        {
            Attribute[] attr1 = Attribute.GetCustomAttributes(typeof(HDFCAccount));
            Attribute[] attr2 = Attribute.GetCustomAttributes(typeof(ICICIAccount));

            Console.WriteLine("-----For HDFC Account-----");
            foreach(Attribute attr in attr1)
            {
                Type t1 = attr.GetType();
                MethodInfo[] methods = t1.GetMethods();
                PropertyInfo[] properties = t1.GetProperties();

                Console.WriteLine("----Method Info-----");
                foreach(MethodInfo method in methods)
                {
                    Console.WriteLine(method.ReturnType.Name + " " + method.Name);
                }

                Console.WriteLine("-----Property Info-----");
                foreach(PropertyInfo property in properties)
                {
                    Console.WriteLine(property.PropertyType.Name + " " + property.Name);
                }
            }
            
            Console.WriteLine("-----For ICICI Account-----");
            foreach(Attribute attr in attr2)
            {
                Type t2 = attr.GetType();
                MethodInfo[] methods = t2.GetMethods();
                PropertyInfo[] properties = t2.GetProperties();

                Console.WriteLine("----Method Info-----");
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine(method.ReturnType.Name + " " + method.Name);
                }

                Console.WriteLine("----Property Info-----");
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine(property.PropertyType.Name + " " + property.Name);
                }
            }
        }
    }
}
