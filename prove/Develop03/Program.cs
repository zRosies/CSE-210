using System;

class Program
{
    static void Main(string[] args)
    {   
        Render Render = new Render();
       string userchoice="";
       do{
        Console.Write("Press enter to continue or type quit to finish");
        userchoice = Console.ReadLine();
        userchoice.ToLower();
         

       }while( userchoice != "quit");
    }
}