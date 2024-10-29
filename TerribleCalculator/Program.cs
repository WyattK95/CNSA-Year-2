using System; 

class Program  
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Let's calculate badly: I hope you like adding because that's all we support.");
        Console.WriteLine("Enter the values to calculate on one line at a time.");
        Console.WriteLine("When you are done, enter the text \"end\" or press CTRL+Z on Windows or CTRL+D on linux.");

        double sum = 0;  
        string input; 

        while (true) 
        {
            input = Console.ReadLine(); 

            if (input == null || input.ToLower() == "end")  
            {
                break;  
            }

            try
            {
                double number = Convert.ToDouble(input);  
                sum = sum + number;  
            }

            catch  
            {
                Console.WriteLine("That's not a number my dude. Try Again.");  
            }
        }

        Console.WriteLine("The answer is: " + sum);  
    }
}
