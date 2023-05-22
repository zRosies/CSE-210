using System;

class Program
{
    static void Main(string[] args)
    {   
        Hide Hide = new Hide();
        Render _Render = new Render(Hide);
        _Render.RenderDefault();
        
        string[] list = {"\n1. Memorize Scripture", "2. Add Scripture","3. Quit"};
        string userchoice="";
       do{  
            Console.WriteLine("\nWelcome to the Scripture Memorizer");
            foreach(string line in list){
                Console.WriteLine(line);
            }
            Console.Write("\nType a number:");
            userchoice = Console.ReadLine();
            userchoice.ToLower();

            if (userchoice == "1"){
                _Render.RenderListOfOptions();
                Console.WriteLine("\nWrite the number of the line you want to memorize");
                userchoice= Console.ReadLine();
                _Render.DisplayScriptures(userchoice);
                
            }
            else if(userchoice == "2"){
                Console.Write("\nWrite the scripture reference. Exemple: John 3:17: ");
                string reference=Console.ReadLine();
                Console.Write("\nWrite the scripture: ");
                string scripture=Console.ReadLine();
                Hide.SetSentence(reference, scripture);
                Console.WriteLine("\nScripture Added");

            }
            else{
                Console.WriteLine("\n Please, choose an number within the list");

            }
            
            

       }while( userchoice != "4");
    }
}