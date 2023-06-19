public class Eternal : CreateGoal{
    string _goal= "";

    public Eternal( List<string> _goals , int _score):base(_goals, _score){
  
    }
    public Eternal(string goal){
        _goal= goal;

    }

    public Eternal(){

    }
    // public override string CreateGoalType(){
        
    // }
    public override void Append(){
        _goals.Add(_goal);
    }


    public override string DisplayGoals(){
        
        string formatted= "";
        for (int i = 0; i < _goals.Count; i++)
        {
            string[] sentence = _goals[i].Split(',');
            string name = sentence[1];
            string description = sentence[2];

            formatted = $". [] {name} ({description})";
          
        }
        return formatted;
    }

    public override int GoalCompleted()
    {
        string eternalGoal="";
        int totalScore=0;
       
        for(int i = 0; i < _goals.Count; i++){
            string[] sentence = _goals[i].Split(',');
            string name=sentence[1];
            string description= sentence[2];
            string score = sentence[3];
            string complete = "true";
            eternalGoal = $"SimpleGoal,{name},{description},{score},{complete};";
            int addscore = int.Parse(score);
            if(complete=="true"){
                totalScore=addscore;
            }

        }
        _score+=totalScore;
        _goals.Remove(_goals[0]);
        _goals.Add(eternalGoal);
        return totalScore;
    }



}