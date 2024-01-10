using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homm24._3
{
    class Stack<T>
    {
        private T[] stackArray;
        private int top;

        public Stack(int size)
        {
            stackArray = new T[size];
            top = -1;
        }

        public void Push(T element)
        {
            if (top == stackArray.Length - 1)
            {
                Console.WriteLine("Stack overflow");
                return;
            }
            stackArray[++top] = element;
        }

        public T Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }
            return stackArray[top--];
        }
    }

    class Program
    {
        static void Main()
        {
            Stack<string> stringStack = new Stack<string>(5);
            stringStack.Push("Tom");
            stringStack.Push("Alice");
            stringStack.Push("Sam");
            stringStack.Push("Kate");

            Console.WriteLine(stringStack.Pop()); // Kate
            Console.WriteLine(stringStack.Pop()); // Sam
            Console.WriteLine(stringStack.Pop()); // Alice
            Console.WriteLine(stringStack.Pop()); // Tom
            Console.WriteLine(stringStack.Pop()); // Stack is empty

            Console.ReadLine();
        }
    }
}
