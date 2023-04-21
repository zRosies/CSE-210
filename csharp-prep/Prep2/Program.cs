using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

         //Grade Simulator
            Console.Write("What is your grade percentage?");
            string str = Console.ReadLine();
            float user = float.Parse(str);
            string letter= "";
            float num = user %10;
            string signal= "";

            if (user >=90)
                {
                    letter = "A";

                }
            else if(user >=80)
                {
                    letter = "B";
                }
            else if(user >= 70)
                {
                    letter = "C";
                }
            else if(user >= 60)
                {
                    letter = "D";
                }
            else 
                { 
                   letter = "F";
                }

            
         
            if (num >=7 && letter != "A" && letter !="F") 
                {
                    signal= "+";
                }
            else if (num < 3 && letter!= "F")
                {
                    signal = "-";
                }
            else
                {
                    signal = "";
                }

          

            if(user >= 70)
                {
                    Console.WriteLine($"\nYou took {letter}{signal}!");
                    Console.WriteLine("Congratulations, you passed!");
                }
            else
                {
                    Console.WriteLine($"\nYou took {letter}{signal}!");
                    Console.WriteLine("Sorry, you didn't pass! Study more next time!");
                    
                }
    }
}