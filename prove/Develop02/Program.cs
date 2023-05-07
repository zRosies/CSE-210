using System;

class Program
{   public static Journal _userchoice= new Journal();
    static void Main(string[] args)
    {
        // Journal journal = new Journal();
        static void GetUserChoice(){
            //Displays the prompt to the user;
            string[] lista={"\n1.Write","2.Display","3.Load","4.Save","5.Erase","6.Quit"};
            string user ="";
            do{
                foreach(string line in lista){
                    Console.WriteLine(line);
                }
                
                Console.WriteLine("\nWhat would you like to do?");
                user=Console.ReadLine();
                // int userchoice= int.Parse(user);
                if(user == "1"){
                    _userchoice.Displayprompt();
                    Console.WriteLine("Answer recorded");
                }
                else if(user == "2"){
                    Journal _userchoice= new Journal();
                    _userchoice.DisplayEntries();
                }
                else if(user == "3"){
                    _userchoice.LoadCsvFile();
                }
                else if(user == "4"){
                    _userchoice.SaveToFile();
                }
                else if(user == "5"){
                    Console.WriteLine("AA");
                }
                else if(user == "6"){
                    Console.WriteLine();
                }
                else{
                    Console.WriteLine("Please, choose a number inside the menu");
                }

            }while(user != "6");
            Console.WriteLine("\nHave a nice day! Come back whenever you want!");
        }
        GetUserChoice();
  
}  }