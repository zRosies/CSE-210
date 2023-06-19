class Program
{
    static void Main(string[] args)
    {
        string[] menu = {"\n1. Create New Goal", "2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Goals", "6. Erase Goal", "7. Quit"};
        string user="";
        List<CreateGoal> goals = new List<CreateGoal>();
        Checklist checklist = new Checklist();
        Eternal eternal = new Eternal();
        Simple simple = new Simple(); 

        do {
            int pontuation =0;
            foreach(CreateGoal go in goals){
                pontuation += go.DisplayScore();
                
            }
            Console.WriteLine($"You have: {pontuation} points");

            Console.WriteLine("\nMenu:");
            foreach(string line in menu) {
                Console.WriteLine(line);
            }
            Console.Write("\nSelect a number from the menu: ");
            user = Console.ReadLine();

            if(user == "1") {
                string choice = simple.DisplayGoalType();
                if(choice == "1") {
                    string goal = simple.CreateGoalType();
                    goals.Add(new Simple(goal)); 
                   
                }
                else if(choice == "2") {
                    string goal = eternal.CreateGoalType();
                    goals.Add(new Eternal(goal)) ;

                }
                else if(choice == "3") {
                    string goal = checklist.CreateGoalType();
                    goals.Add(new Checklist(goal));
                
                }
                foreach(CreateGoal go in goals){
                        go.Append();
                    }
            }
            else if(user == "2") {
                int count=1;
                foreach(CreateGoal go in goals) {
                    Console.WriteLine($"{count}{go.DisplayGoals()}");
                    count++;
                }
            }
            else if(user == "3") {
                List<string> test = new List<string>();
                foreach(CreateGoal go in goals){
                    test.Add(go.SaveToFile());
                }
                // Console.Write(test[0]);

                Console.WriteLine("Write your file name to save: ");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName)){
                    foreach(string line in test){
                         outputFile.WriteLine($"{line}");
                    }
                   
                }

            }
            else if(user == "4") {
                Console.WriteLine("Write the file you want to load name: ");
                string fileName = Console.ReadLine();
                string[] file = System.IO.File.ReadAllLines(fileName);

                foreach(string line in file){
                   string[] parts = line.Split(",");
                   string goalType= parts[0];
                   string name = parts[1];
                   string description= parts[2];
                   string score= parts[3];
                   
                   

                    if(goalType=="SimpleGoal"){
                        // string boolean= parts[4];
                        // string aa= $"{goalType},{name},{description},{score},{boolean};";
                        goals.Add(new Simple(line));

                    }
                    else if(goalType=="Checklist"){
                        // string bonus= parts[4];
                        // string timesdone= parts[5];
                        // string timestobedone=parts[6];
                        // string aa = $"{goalType},{name},{description},{score},{bonus},{timesdone},{timestobedone};";
                        goals.Add(new Checklist(line));

                    }
                    else{
                        goals.Add(new Eternal($"{goalType},{name},{description},{score};"));
                    }
                //     

                }


            }
            else if(user == "5") {
                int count = 1;
                foreach(CreateGoal go in goals){
                    Console.WriteLine($"{count}{go.DisplayGoals()}");
                    count ++;
                }

                Console.WriteLine("Which goal did you accomplish?");
                string goalAccomplished= Console.ReadLine();
                int goalIndex= int.Parse(goalAccomplished)-1;
                CreateGoal goalSelected = goals[goalIndex];
                int points = goalSelected.GoalCompleted();
                
                Console.WriteLine($"\nCongratulations, you've earned {points} points.");

            }
            else if(user == "6") {

            }
            else if(user == "7") {

            }
            else {
                Console.WriteLine("\nChoose a number within the list");
            }
        }
        while(user != "7");
    }
}