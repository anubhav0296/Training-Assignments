using System;



namespace Assignment_5_C_Sharp
{
    class Program
    {
        public static void copy<T>(T[] array)
        {
            T[] newArray = new T[array.Length];
            Array.Copy(array, newArray, array.Length);
            display<T>(array);
        }
        public static void sort<T>(T[] array)
        {
            Array.Sort(array);
            display<T>(array);
        }
        public static void clear<T>(T[] array)
        {
            Array.Clear(array, 0, array.Length);
            display<T>(array);
        }
        public static void reverse<T>(T[] array)
        {
            Array.Reverse(array);
            display<T>(array);
        }
        public static void display<T>(T[] array)
        {
            Console.WriteLine("Displaying Array.....");
            foreach (T t in array)
            {
                if (t.Equals(null))
                {
                    Console.Write("null ");
                }
                else
                {
                    Console.Write(t + " ");
                }
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            int n;
            int[] array1 = new int[5];
            string[] array2 = new string[5];
            Console.WriteLine($"Enter 5 integers.");
            for (int i = 0; i < 5; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Enter {5} Strings.");
            for (int i = 0; i < 5; i++)
            {
                array2[i] = Console.ReadLine();
            }



            do
            {
                Console.WriteLine("Enter Choice");
                Console.WriteLine("1.Copy");
                Console.WriteLine("2.Sort");
                Console.WriteLine("3.Clear");
                Console.WriteLine("4.Reverse");
                Console.WriteLine("5.Exit");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        copy(array1);
                        copy(array2);
                        break;
                    case 2:
                        sort(array1);
                        sort(array2);
                        break;
                    case 3:
                        clear(array1);
                        clear(array2);
                        break;
                    case 4:
                        reverse(array1);
                        reverse(array2);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            } while (n != 5);
        }

    }
}
