using System;


namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Sandbox World!!!");
            

             //     Console.Write("What is your favorite color? ");
                //     string color = Console.ReadLine()
                // Console.Write("Choose a number:");
                // string xstring = Console.ReadLine();
                // int x = int.Parse(xstring);

                // int y=3;
                // if (x>y)
                // {
                //     Console.WriteLine($"The number you chose is {x}  is Correct");
                // }
                // else{
                //     Console.WriteLine($"The number you chose is {x} is Incorrect");
                // }
                //    Console.Write("What is your name?");
            string first = Console.ReadLine();
            Console.Write("What is your last name?");
            string last = Console.ReadLine();

            Console.Write($"\nYour name is {last}, {first} {last}!");
        }


    }
}
