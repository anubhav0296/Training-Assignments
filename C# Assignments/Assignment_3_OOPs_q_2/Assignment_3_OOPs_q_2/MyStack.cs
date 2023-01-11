using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_OOPs_q_2
{
    public interface ICloneable
    {
        object Clone();
    }

    public class StackException : Exception
    {
        public StackException(string message) : base(message) { }
    }
    public class MyStack : ICloneable
    {
        public int[] arr = new int[30];
        public int top = -1;
        public int size;

        public void PUSH(int n)
        {
            try
            {
                if(top == arr.Length - 1)
                {
                    throw new StackException("Full Stack Exception.");
                }
                arr[++top] = n;
                Console.WriteLine($"\nPushed {n} onto the stack");
            }
            catch(StackException stck)
            {
                Console.WriteLine(stck);
            }
        }
        public void POP()
        {
            try
            {
                if (top == -1)
                {
                    throw new StackException("Empty Stack Exception.");
                }
                Console.WriteLine($"\n {arr[top]} popped.");
                arr[top--] = 0;
                
            }
            catch (StackException stck)
            {
                Console.WriteLine(stck);
            }
        }
        public object Clone()
        {
            Console.WriteLine("Cloning Array....");
            MyStack new_my_Stack = new MyStack
            {
                arr = this.arr,
                size = this.size,
                top = this.size
            };
            return new_my_Stack;
        }

        public int SIZE
        {
            get
            {
                return size;
            }
            set
            {
                this.size = arr.Length;
            }
        }

        public void SHOW_DETAILS()
        {
            Console.WriteLine("\n Printing  ");
            foreach(int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
