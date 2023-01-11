using System;

namespace Q_4_MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stack = new MyStack<string>();
            stack.push("My");
            stack.push("name");
            stack.push("is");
            stack.push("Anubhav");
            stack.push("Srivastava");
            stack.push("Srivastava");
            stack.pop();
            stack.display();
            Console.ReadKey();
        }
    }
}
