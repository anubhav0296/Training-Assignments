using System;
using System.Collections.Generic;

namespace Ass_5_self
{
    class Program
    {
        public static void Copy<T>(T[] array)
        {
            T[] newarray = new T [array.Length];
            Array.Copy(array, newarray, array.Length);
            Display<T>(array);
        }
        
        public static void Sort<T>(T[] array)
        {
            Array.Sort(array);
            Display<T>(array);
        }
        
        public static void Clear<T>(T[] array)
        {
            Array.Clear(array, 0, array.Length);
            Display<T>(array);
        }
        
        public static void Reverse<T>(T[] array)
        {
            Array.Reverse(array);
            Display<T>(array);
        }

        // Displaying the arrays
        public static void Display<T>(T[] array)
        {
            Console.WriteLine("Displaying the array");
            foreach(T t in array)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            // Creating 2 types of arrays - Integer and string
            int[] arr = new int[5] { 34, 57,11, 79, 9 };
            string[] name = new string[] { "Shanu", "Ankit", "Abhishek", "Anmol" };

            int n;
            

            do
            {
                Console.WriteLine("Perform following Operations");
                Console.WriteLine("1. Copy");
                Console.WriteLine("2. Sort");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Reverse");
                Console.WriteLine("5. Exit");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Copy(arr);
                        Copy(name);
                        break;
                    case 2:
                        Sort(arr);
                        Sort(name);
                        break;
                    case 3:
                        Clear(arr);
                        Clear(name);
                        break;
                    case 4:
                        Reverse(arr);
                        Reverse(name);
                        break;
                    case 5:
                        Console.WriteLine("Exiting the loop");
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }

            } while (n != 5);
            



        }
    }
}
