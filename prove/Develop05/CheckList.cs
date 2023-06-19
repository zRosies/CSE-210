public class Checklist : CreateGoal{
    string _goal = "";
    public Checklist( List<string> _goals , int _score, string goal):base(_goals, _score){
        goal=_goal;
    }
    public Checklist(string goal){
        _goal=goal;
    }
 
    public Checklist(){

    }

    public override string CreateGoalType(){
       
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("What is a sort description of it?");
        string description= Console.ReadLine();

        Console.WriteLine("What is the amount of poins associated with this goal?");
        string score= Console.ReadLine();

        Console.WriteLine("How many times does this goal need to be accomplish for a bonus?");
        string timestobedone= Console.ReadLine();

        Console.WriteLine("What is the the bonus for accomplishing it many times?");
        string bonus= Console.ReadLine();

        int timesdone= 0;

        string simpleGoal = $"Checklist,{name},{description},{score},{bonus},{timesdone},{timestobedone};";

        return simpleGoal;

    }

    public override int GoalCompleted(){
        string checklistGoal="";
        int totalScore=0;
        int addBonus=0;
        
        for(int i = 0; i < _goals.Count; i++){
            string[] sentence = _goals[i].Split(',');
            string name = sentence[1];
            string description = sentence[2];
            string score = sentence[3];
            string bonus = sentence[4];
            string timesdone = sentence[5];
            string timestobedone = sentence[6];
            string tdcorrect = timestobedone.TrimEnd(';');

            int addTimesDone=int.Parse(timesdone) + 1;
            int verify = int.Parse(tdcorrect);
            totalScore=int.Parse(score);

            if(addTimesDone == verify){
               
                addBonus=int.Parse(bonus);
                Console.WriteLine($"\nCongratulations for accomplishing this goal!\nYou have earned a bonus of {bonus} points!");

            }
            // string complete = "true";
            checklistGoal = $"Checklist,{name},{description},{score},{bonus},{addTimesDone},{tdcorrect};";
            int addscore = int.Parse(score);


        }
        _goals.Remove(_goals[0]);
        _goals.Add(checklistGoal);
        _score+=addBonus;
        _score+=totalScore;
        
        return totalScore;

    }

    public override string DisplayGoals()
    {

        string formatted="";
        for (int i = 0; i < _goals.Count; i++)
        {
            string[] sentence = _goals[i].Split(',');
            string name = sentence[1];
            string description = sentence[2];
            string timesdone = sentence[5];
            string timestobedone = sentence[6];
           
            string tdcorrect = timestobedone.TrimEnd(';');
            if(timesdone == tdcorrect){
                formatted = $". [X] {name} ({description}) -- Current completed: {timesdone}/{tdcorrect}";
            }
            else{
                formatted = $". [] {name} ({description}) -- Current completed: {timesdone}/{tdcorrect}";
            
            }
           

            
        }
        return formatted;
    }
    
    public override void Append(){
        _goals.Add(_goal);
    }


}