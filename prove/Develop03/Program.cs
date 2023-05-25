using System;

class Program
{
    static void Main(string[] args)
    {   
        Hide _Hide = new Hide();
        Render _Render = new Render(_Hide);
        _Render.RenderDefault();

        // Menu using an array and basic while loop//
        string[] list = {"\n1. Memorize Scripture", "2. Add Scripture","3. Display list of Scriptures", "4. Quit"};
        string userchoice="";
       do{  
            Console.WriteLine("\nWelcome to the Scripture Memorizer");
            foreach(string line in list){
                Console.WriteLine(line);
            }

            Console.Write("\nType a number:");
            userchoice = Console.ReadLine();

            if (userchoice == "1"){
                _Render.RenderListOfOptions();
                Console.WriteLine("\nWrite the number of the scripture(Ex: if you want to memorize John 3:17 type 1):");
                userchoice= Console.ReadLine();
                _Render.DisplayScriptures(userchoice);
                userchoice="1";              
            }
            else if(userchoice == "2"){
                Console.Write("\nWrite the scripture reference. Exemple: John 3:17: ");
                string reference=Console.ReadLine();
                Console.Write("\nWrite the scripture: ");
                string scripture=Console.ReadLine();
                _Hide.SetSentence(reference, scripture);
                Console.WriteLine("\nScripture Added");

            }
            else if(userchoice == "3"){
                _Render.RenderListOfOptions();

            }
            else if(userchoice == "4"){
                Console.WriteLine("\nHave a nice day :D");
                userchoice="4";
            }
            else{
                Console.WriteLine("\nPlease, choose an number within the list");

            }
        }while( userchoice != "4");
    }
}