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
        int counter= 0;

        do {
            int pontuation =0;
            foreach(CreateGoal go in goals){
                pontuation += go.DisplayScore();
                
            }
            Console.WriteLine($"You have: {pontuation} points.");

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
                CreateGoal go = goals[counter];
                    go.Append();
                counter++;
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
                string test="";
                foreach(string line in file){
                   string[] parts = line.Split(",");
                   string goalType= parts[0];                   

                    if(goalType=="SimpleGoal"){
                        
                        goals.Add(new Simple(line));

                    }
                    else if(goalType=="Checklist"){
                        
                        goals.Add(new Checklist(line));

                    }
                    else{
                        goals.Add(new Eternal(line));
                    }
                    test=line;

                }
                foreach(CreateGoal go in goals){
                        go.Append();
                        go.AppendGoalsfromFile();
                        counter++;
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
                int num = 1;
                foreach(CreateGoal newg in goals){
                   Console.WriteLine($"{num}{newg.DisplayGoals()}");
                   num ++;
                }
                Console.WriteLine("Choose the line you want to remove: ");
                string remove = Console.ReadLine();
                int index = int.Parse(remove)-1;
                CreateGoal go = goals[index];
                goals.Remove(goals[index]);
                Console.WriteLine("\nThis goal has been removed.");
                counter --;

            }
            else if(user == "7") {
                    Console.WriteLine("\nThanks for comming :D!");
            }
            else {
                Console.WriteLine("\nChoose a number within the list");
            }
        }
        while(user != "7");
    }
}