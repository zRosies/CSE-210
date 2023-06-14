public class Eternal : CreateGoal{

    public Eternal( List<string> _goals , int _score):base(_goals, _score){
  
    }
    public Eternal(){

    }
    public string CreateEternalGoal(){
       
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("What is a sort description of it?");
        string description= Console.ReadLine();

        Console.WriteLine("What is the amount of poins associated with this goal?");
        string score= Console.ReadLine();

        string simpleGoal = $"Checkilist:{name},{description},{score},{score};";

        return simpleGoal;

    }

    public override void DisplayGoals(){
        
        for (int i = 0; i < _goals.Count; i++)
        {
            string[] sentence = _goals[i].Split(';');
            string name = sentence[0];
            string description = sentence[1];

            string formatted = $"{i + 1}. [] {name} ({description})";
            Console.WriteLine(formatted);
        }
    }



}