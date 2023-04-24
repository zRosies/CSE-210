using System;

class Program
{
    static void Main(string[] args)
    {    {
        Random random = new Random();
        int magicnum = random.Next(0,101);
        int numgues=-1;
        int guest= 0;
        string play="";
        while (numgues != magicnum || play=="yes"){
            guest += 1;
            Console.Write("What is the magic number?");
            string guess = Console.ReadLine();
            numgues= int.Parse(guess);
            if (magicnum > numgues){
                Console.WriteLine("Heigher");
            }
            else if (magicnum < numgues){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine($"\nCongratulations, you've find the magic number. You took {guest} attempts!");
                Console.Write("Do you want to play again?(yes/no)");
                play=Console.ReadLine();
            }
            if (magicnum==numgues && play!="no"){
                guest=0;
                magicnum=random.Next(0,10);
            }
            
        }
      
        }        
    }
}