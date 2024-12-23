using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day09
{
    internal class Stack<T>
    {
        const int Count = 10;
           static T[] array = new T[Count];
           static int top = -1;

        public static void push(T value)
        {
            if (top ==array.Length-1)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                array[++top] = value;    
            }
        }

        public static void pop ()
        {
           if (top==-1)
            {
                Console.WriteLine("the stack is empty");
            }
           else
            {
                array[top--] = default;
            }
        }
        public static T peek ()
        {
            return array[top];
        }

       
    }
}
