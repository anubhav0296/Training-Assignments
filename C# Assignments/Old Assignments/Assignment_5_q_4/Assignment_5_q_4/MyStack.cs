using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_q_4
{
    class MyStack<T>
    {
        private T[] arr = new T[10];
        private int top = -1;
        private int size;

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

        public MyStack()
        {
            this.SIZE = SIZE;
        }

        public void push(T el)
        {
            try
            {
                if (top == SIZE - 1)
                {
                    throw new Exception("Fullstack Exception.");
                }
                arr[++top] = el;
                Console.WriteLine($"Pushed {el} onto the stack.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void pop()
        {
            try
            {
                if (top == -1)
                {
                    throw new Exception("EmptyStack Exception.");
                }
                Console.WriteLine($"\n{arr[top]} popped.");
                Array.Clear(arr, top--, 1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }
        public void display()
        {
            Console.WriteLine("\nPrinting...");
            for (int i =0; i < SIZE; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
