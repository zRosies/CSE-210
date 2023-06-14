public class CreateGoal{
    protected List<string> _goals = new List<string>();
    private string[] _goalMenu = {"1. Simple Goal", "2. Eternal", "3. Checklist Goal"};
    protected int _score=0;

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


    public string DisplayGoalMenu(){
        string user="";
        Console.WriteLine("\nThe types of goals are: ");
        foreach(string line in _goalMenu){
                Console.WriteLine(line);
            }
        Console.Write("Which type of goal would you like to create?");
        user = Console.ReadLine();
            return user;    

    }


    public int DisplayScore(){
        return _score;
    }

    public virtual void DisplayGoals(){
        foreach(string line in _goals){
            Console.WriteLine(line);
        }

    }

    public void AddGoals(string goal){
        _goals.Add(goal);
    }

    //stretch challenge

    public void EraseGoal(){

    }





}