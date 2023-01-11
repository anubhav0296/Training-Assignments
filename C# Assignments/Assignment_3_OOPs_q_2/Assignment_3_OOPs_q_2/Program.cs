using System;

namespace Assignment_3_OOPs_q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            MyStack ms = new MyStack();
            try
            {
                do
                {
                    Console.WriteLine("Enter Choice:");
                    Console.WriteLine("1.Push");
                    Console.WriteLine("2.Pop");
                    Console.WriteLine("3.Display");
                    Console.WriteLine("4.Clone");
                    Console.WriteLine("5.Exit");

                    n = Convert.ToInt32(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Enter element");
                            int num = Convert.ToInt32(Console.ReadLine());
                            ms.PUSH(num);
                            break;
                        case 2:
                            ms.POP();
                            break;
                        case 3:
                            ms.SHOW_DETAILS();
                            break;
                        case 4:
                            MyStack newStack = ms.Clone() as MyStack;
                            newStack.SHOW_DETAILS();
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Enter a valid choice");
                            break;

                    }
                }
                while (n != 5);
            }
            catch(StackException ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
