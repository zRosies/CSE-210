public class CreateGoal{
    protected List<string> _goals = new List<string>();
    protected string[] _goalMenu = {"1. Simple Goal", "2. Eternal", "3. Checklist Goal"};
    protected int _score=0;

    string _goal = "";

    public CreateGoal ( List<string> goals , int score){
       _score= score;
        _goals= goals;
    }
    public CreateGoal(){

    }

    
    public int getSetScore{
        get{return _score;}
        set{_score=value;}
    }

    public string DisplayGoalType(){
        string user="";
        Console.WriteLine("\nThe types of goals are: ");
        foreach(string line in _goalMenu){
                Console.WriteLine(line);
            }
        Console.Write("Which type of goal would you like to create?");
        user = Console.ReadLine();
        return user;
    }

    public virtual void Append(){
        _goals.Add(_goal);
    }


    public int DisplayScore(){
        return _score;
    }

    public virtual string DisplayGoals(){
        return "";

    }

    public virtual string CreateGoalType(){
        
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("What is a sort description of it?");
        string description= Console.ReadLine();

        Console.WriteLine("What is the amount of poins associated with this goal?");
        string score= Console.ReadLine();

        string simpleGoal = $"Eternal,{name},{description},{score},{score};";

        return simpleGoal;

    }
    

    public virtual string SaveToFile(){
        string goal = "";
        foreach(string line in _goals){
            goal=line;
        }
        return goal;
       


    }

    public void AddGoals(string goal){
        _goals.Add(goal);
    }

    public void EraseGoal(){

    }

   public virtual int GoalCompleted(){
    return 0;
    
   }





}