using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to Mindfulness");
        string[] menu ={"\n1. Start breathing activity", "2. Start reflecting activity", "3. Start writing activity", "4. Start focus activity", "5. Quit"};
        string user="";
        do{
            foreach(string line in menu){
                Console.WriteLine(line);
            }
            Console.Write("\nSelect a choice from the menu: ");
            user= Console.ReadLine();
            if(user == "1"){
                BreathingActivity breath = new BreathingActivity();
                breath.getSetActivityName="Breathing Activity";
                breath.getSetDescription=@"This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
                int actvduration = breath.startingMessage();
                breath.getSetActivityDuration= actvduration;
                Console.WriteLine("Get ready...");
                breath.animation(3);
                breath.Breathing();
                breath.startEndingMessage();


            }
            else if(user == "2"){
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.getSetActivityName="Reflecting Activity";
                reflect.getSetDescription= "This activity you help you reflect on times in life when you shown strength and resilience. this will help you recognize the power yu have and how you can use it in other aspects of your life";
                int actvduration= reflect.startingMessage();
                reflect.getSetActivityDuration=actvduration;
                Console.WriteLine("Get ready...");
                reflect.animation(3);
                reflect.promptRandomQuestions(actvduration);
                reflect.startEndingMessage();

            }
            else if(user == "3"){
                WritingActivity write= new WritingActivity();
                write.getSetActivityName="Writting Activity";
                write.getSetDescription="This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.";
                int actvduration= write.startingMessage();
                write.getSetActivityDuration=actvduration;
                Console.WriteLine("Get ready...");
                write.animation(3);
                write.writeExperiences();
                write.startEndingMessage();
            }
            else if(user == "4"){
                FocusActivity focus = new FocusActivity();
                focus.getSetActivityName="Focus Activity";
                focus.getSetDescription="This activity will help you maintain your focus on the present time by helpig you to answer a couple of questions in a certain amount of time.";
                int actvduration = focus.startingMessage();
                focus.getSetActivityDuration=actvduration;
                Console.WriteLine("\nGet ready...");
                focus.animation(3);
                focus.RenderFocusActivity();
                focus.startEndingMessage();
            }
            else if(user == "5"){
                Console.WriteLine("\nThanks for comming!\nHave a wonderful day :D!");
            }
           
            else{
                Console.WriteLine("\nCharacter not allowed!\nPlase, choose a number within the menu.");
            
            }
        }while(user != "5");
    }
}