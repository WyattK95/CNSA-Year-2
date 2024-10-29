using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0 && args[0] == "R")
        {
            string[] words = new string[args.Length - 1];
            Array.Copy(args, 1, words, 0, args.Length - 1);
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
        }
        else
        {
            Console.WriteLine(string.Join(" ", args));
        }
    }
}
