class Program
{
    static void Main(string[] args)
    {
        string[] menu = {"\n1. Create New Goal", "2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Goals", "6. Erase Goal", "7. Quit"};
        string user="";
        CreateGoal goal = new CreateGoal();

        do{
            Console.WriteLine("\nMenu:");
            foreach(string line in menu){
                Console.WriteLine(line);
            }
            Console.Write("\nSelect a number from the menu: ");
            user = Console.ReadLine();

            if(user=="1"){
                string choice = goal.DisplayGoalMenu();
                if(choice == "1"){
                    Simple simple = new Simple();
                    goal.AddGoals(simple.CreateSimpleGoal());
                }
                else if(choice =="2"){
                    Eternal eternal= new Eternal();
                    goal.AddGoals(eternal.CreateEternalGoal());
                }
                else if(choice == "3"){
                    Checklist checklist = new Checklist();
                    goal.AddGoals(checklist.CreateCheckGoal());
                }
            }
            else if(user=="2"){
               
            }
            else if(user=="3"){

            }
            else if(user=="4"){

            }
            else if(user=="5"){

            }
            else if(user=="6"){

            }
            else if(user=="7"){

            }
            else{
                Console.WriteLine("\nChoose a number within the list");
            }
        }
        while(user!="7");
    }
}