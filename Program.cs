using System;
using System.Linq;
using System.Collections.Generic;

namespace CompareLongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] characters = text.ToCharArray();

            var queue = new Queue<string>(characters.Select(x => x.ToString()));
            var stack = new Stack<string>(characters.Select(x => x.ToString()));

            int count = 0;
            int length = queue.Count();

            while (queue.Any())
            {
                int first = int.Parse(queue.Dequeue());
                int last = int.Parse(stack.Pop());

                if (first > last)
                {
                    Console.WriteLine("From left to right is bigger");
                    break;
                }
                else if (last > first)
                {
                    Console.WriteLine("From right to left is bigger");
                    break;
                }
                else if (first == last)
                {
                    count++;
                }
            }

            if (count == length)
            {
                Console.WriteLine("The numbers are equal");
            }

        }
    }
}
