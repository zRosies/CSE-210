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
        
        bool compelte= false;

        string simpleGoal = $"Eternal,{name},{description},{score},{compelte};";

        return simpleGoal;

    }
    

    public virtual string SaveToFile(){
        string goal = "";
        foreach(string line in _goals){
            goal=line;
        }
        return goal;
       


    }

    public void AppendGoalsfromFile()
    {
        foreach (string line in _goals)
        {
            if (!string.IsNullOrEmpty(line))
            {
                string[] sentence = line.Split(",");
                string goalType = sentence[0];

                if (goalType == "SimpleGoal" || goalType == "Eternal")
                {
                    string complete = sentence[4];
                    string score = sentence[3];
                    int addScore = int.Parse(score);
                    if (complete == "true;")
                    {
                        _score += addScore;
                    }
                }
                else if (goalType == "Checklist")
                {
                    string score = sentence[3];
                    string bonus = sentence[4];
                    string timesdone = sentence[5];
                    string timestobedone = sentence[6];
                    int scoreParsed = int.Parse(score);
                    int bonusParsed = int.Parse(bonus);
                    int timesdoneParsed = int.Parse(timesdone);

                    _score += timesdoneParsed * scoreParsed;

                    if (timesdone == timestobedone.TrimEnd(';'))
                    {
                        _score += bonusParsed;
                    }
                }
                else
                {
             
                  
                 
                }

                
            }
        
        }
        
    }

    public void EraseGoal(){
        _goals.Remove(_goals[0]);

    }

   public virtual int GoalCompleted(){
    return 0;
    
   }





}