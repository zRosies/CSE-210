using System;

class Program
{   public static Journal _userChoice= new Journal();

    static void Main(string[] args)
    {
        static void GetUserChoice(){
            Console.WriteLine("Welcome to your friendly journal!");
            //Displays the MENU;
            string[] lista={"\n1.Write","2.Display","3.Load","4.Save","5.Erase","6.Quit"};
            string user ="";

            do{
                foreach(string line in lista){
                    Console.WriteLine(line);
                }
                
                Console.WriteLine("\nWhat would you like to do?");
                user=Console.ReadLine();
    
                if(user == "1"){
                    _userChoice.Displayprompt();
                    Console.WriteLine("Answer recorded!");
                }
                else if(user == "2"){
                    _userChoice.DisplayEntries();
                }
                else if(user == "3"){
                    _userChoice.LoadCsvFile();
                    Console.WriteLine("\nFile Loaded!");
                }
                else if(user == "4"){
                    _userChoice.SaveToFile();
                    Console.WriteLine("\nFile Saved!");
                    
                }
                else if(user == "5"){
                    _userChoice.EraseJournal();
                    Console.WriteLine("\nItem Removed!");
                    
                }
                else if(user == "6"){
                    Console.WriteLine();
                }
                else{
                    Console.WriteLine("\nPlease, choose a number inside the menu");
                }

            }while(user != "6");
            Console.WriteLine("\nHave a nice day! Come back whenever you want!");
        }
        GetUserChoice();
  
}  }
