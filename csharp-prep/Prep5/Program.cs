using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("What's your name?");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What's your number?");
            string name = Console.ReadLine();
            int num = int.Parse(name);
            return num;
        }
        static int SquareNumber(int num)    
        {
            int total = num*num;
            return total;
        }
        static void DisplayResult(int num, string name)
        {
            Console.WriteLine($"{name}, the square of your number is {num}");
        }
        DisplayWelcome();
        string name =PromptUserName();
        int num = PromptUserNumber();
        num=SquareNumber(num);
        DisplayResult(num,name);
        
    }
}