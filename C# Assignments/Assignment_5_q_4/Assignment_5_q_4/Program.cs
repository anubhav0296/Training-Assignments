using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_q_4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                MyStack<string> stack = new MyStack<string>();
                stack.push("Anubhav");
                stack.push("Ankit");
                stack.push("Shanu");
                stack.push("Rajdeep");
                stack.push("Sahu");
                stack.push("Aniket");
                stack.pop();
                stack.display();
                Console.ReadKey();
            }
        }
    }
}
