using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity = new List<Activity>();
        // Cycling cycling= new Cycling();
        // Swimming swimming= new Swimming();
        // Running running = new Running();
        DateTime currentDate = DateTime.Now;
        string user="";
        string[] menu ={"\n1. Running", "2. Cycling", "3. Swimming", "4. Display Activities", "5. Quit"};
        

        do{
            foreach(string line in menu){
                Console.WriteLine(line);
            }
            Console.WriteLine("Select an option:");
            user = Console.ReadLine();
            if(user=="1"){
                Console.WriteLine("Write the distance performed in km this activity(Ex:32):");
                string response = Console.ReadLine();
                float distance = float.Parse(response);
                Console.WriteLine("Write the minutes spent in this Activity(Ex: 30): ");
                string response2 = Console.ReadLine();
                float minutes = float.Parse(response2);
                activity.Add(new Running(distance,currentDate.ToShortDateString(), minutes, "Running"));
                Console.WriteLine("\nYour answer has been recorded!");
                
            }
            else if(user=="2"){
                Console.WriteLine("Write the speed in km/h performed in this activity(Ex:32):");
                string response = Console.ReadLine();
                float speed = float.Parse(response);
                Console.WriteLine("Write the minutes performed in this activity(Ex:15):");
                string response2 = Console.ReadLine();
                float minutes = float.Parse(response2);


                activity.Add(new Cycling(speed,currentDate.ToShortDateString(), minutes, "Cycling"));
                 Console.WriteLine("\nYour answer has been recorded!");
               
             }
            else if(user =="3"){
                Console.WriteLine("Write the number of laps performed in this activity(Ex:32):");
                string response = Console.ReadLine();
                float numberOfLaps = float.Parse(response);
                Console.WriteLine("Write the minutes performed in this activity(Ex:15):");
                string response2 = Console.ReadLine();
                float minutes = float.Parse(response2);

                activity.Add(new Swimming(numberOfLaps,currentDate.ToShortDateString(), minutes, "Swimming"));
                Console.WriteLine("\nYour answer has been recorded!");
            }
            else if(user =="4"){
                Console.WriteLine("...................................................................................................................");
                Console.WriteLine();
                foreach(Activity line in activity){
                    Console.WriteLine(line.GetSummary());
                }
                Console.WriteLine("...................................................................................................................");
            }
            else{
                Console.WriteLine("Write a number within the menu.");

            }
             


        }while(user != "5");
    }
}