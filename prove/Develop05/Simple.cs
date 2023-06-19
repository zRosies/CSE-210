public class Simple:CreateGoal{
    string _goal = "";
    public Simple( List<string> _goals , int _score, string goal ):base(_goals, _score){
        _goal=goal;
    }

    public Simple(string goals){
        _goal= goals;

    }
    public Simple(){

    }

    public override string CreateGoalType(){

        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("What is a sort description of it?");
        string description= Console.ReadLine();

        Console.WriteLine("What is the amount of poins associated with this goal?");
        string score= Console.ReadLine();

        bool complete= false;

        string simpleGoal = $"SimpleGoal,{name},{description},{score},{complete};";
        return simpleGoal;

    }



    public override string DisplayGoals()
    {
        string formatted="";
        for (int i = 0; i < _goals.Count; i++)
        {
            string[] sentence = _goals[i].Split(',');
            string name = sentence[1];
            string description = sentence[2];
            string comeplete= sentence[4];
            if(comeplete=="true;"){
                formatted = $". [X] {name} ({description})";
            }
            else{
                formatted=$". [] {name} ({description})";

            }
            // string description = sentence[1];

        }
        return formatted;
      
    }

    public override int GoalCompleted(){
        string simpleGoal="";
        int totalScore=0;
       
        for(int i = 0; i < _goals.Count; i++){
            string[] sentence = _goals[i].Split(',');
            string name=sentence[1];
            string description= sentence[2];
            string score = sentence[3];
            string complete = "true";
            simpleGoal = $"SimpleGoal,{name},{description},{score},{complete};";
            int addscore = int.Parse(score);
            if(complete=="true"){
                totalScore=addscore;
            }

        }
        _score+=totalScore;
        _goals.Remove(_goals[0]);
        _goals.Add(simpleGoal);
        return totalScore;

    }

    public override void Append(){
        _goals.Add(_goal);
    }

    

}