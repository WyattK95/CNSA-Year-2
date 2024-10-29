using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Greetings Professor Falken. Do you want to play a game? Let's find palindromes.");
        Console.WriteLine("Enter a potential palindrome and press enter.");

        string input;

        while ((input = Console.ReadLine()) != null)
        {
            string cleanedInput = RemoveWhitespace(input);

            string reversedInput = ReverseString(cleanedInput);

            if (cleanedInput.Equals(reversedInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Palindrome unlocked");
            }
            else
            {
                Console.WriteLine("Whomp, whomp.");
            }
        }
    }

    static string RemoveWhitespace(string str)
    {
        return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
