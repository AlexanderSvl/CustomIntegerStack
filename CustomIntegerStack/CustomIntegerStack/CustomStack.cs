using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomIntegerStack
{
    public class CustomStack<T>
    {
        private readonly IList<T> stackData;

        public CustomStack()
        {
            this.stackData = new List<T>();
        }

        public void Push(params T[] items)
        {
            foreach (T item in items)
            {
                this.stackData.Add(item);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Element {item} added to stack.");
                Console.ResetColor();
            }
        }

        public void Pop()
        {
            if (this.stackData.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No elements in the stack. Use command PUSH to add an item.");
                Console.ResetColor();
            }
            else
            {
                T element = this.stackData[this.stackData.Count - 1];
                int index = this.stackData.Count - 1;

                this.stackData.RemoveAt(this.stackData.Count - 1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Element {element} at index {index} is removed.");
                Console.ResetColor();
            }
        }

        public void Peek()
        {
            if (this.stackData.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No elements in the stack. Use command PUSH to add an item.");
                Console.ResetColor();
            }
            else
            {
                T element = this.stackData[this.stackData.Count - 1];
                int index = this.stackData.Count - 1;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Peeked element {element} is at index {index}.");
                Console.ResetColor();
            }
        }

        public void Print()
        {
            if (stackData.Count != 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Elements in stack: ");
                Console.WriteLine(String.Join(", ", stackData));
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No elements in the stack. Use command PUSH to add an item.");
                Console.ResetColor();
            }
        }

        public void Empty()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Stack is cleared.");
            Console.ResetColor();

            this.stackData.Clear();
        }
    }
}
