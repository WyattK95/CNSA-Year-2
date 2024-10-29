using System;

namespace HellowWorldProject
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"Hi from CNSA 212, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hi from CNSA 212, user!");
            }
        }
    }
}
