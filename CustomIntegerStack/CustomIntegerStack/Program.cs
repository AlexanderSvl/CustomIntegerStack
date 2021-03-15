using System;
using System.Linq;

namespace CustomIntegerStack
{
    public class StartUp
    {
        public static void Main()
        {
            CustomStack<int> customStack = new CustomStack<int>();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter one of the following commands:");
            Console.WriteLine("PUSH - Pushes an element/s into the stack.");
            Console.WriteLine("POP - Pops an element from the stack.");
            Console.WriteLine("PEEK - Peeks the element at the top of the stack.");
            Console.WriteLine("CLEAR - Clears the stack.");
            Console.WriteLine("END - Exit the program.");
            Console.WriteLine("PRINT - Prints the stack into the console.");
            Console.WriteLine();
            Console.ResetColor();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];

                try
                {
                    switch (command)
                    {
                        case "PUSH":
                            if (parts.Length == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Command PUSH requires element/s to push. Example: PUSH 3; PUSH 5 6; PUSH abc def ghi;");
                                Console.ResetColor();
                            }
                            else
                            {
                                customStack.Push(parts.Skip(1).Select(int.Parse).ToArray());
                            }

                            break;
                        case "POP":
                            customStack.Pop();
                            break;
                        case "PEEK":
                            customStack.Peek();
                            break;
                        case "PRINT":
                            customStack.Print();
                            break;
                        case "CLEAR":
                            customStack.Empty();
                            break;
                        case "END":
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Command is not recognised");
                            Console.ResetColor();
                            break;
                    }
                }
                catch (Exception exp)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(exp.Message);
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Enter one of the following commands:");
                Console.WriteLine("PUSH - Pushes an element into the stack.");
                Console.WriteLine("POP - Pops an element from the stack.");
                Console.WriteLine("END - Exit the program.");
                Console.WriteLine("PRINT - Prints the stack into the console.");
                Console.WriteLine();
                Console.ResetColor();

                input = Console.ReadLine();
            }

        }
    }
}