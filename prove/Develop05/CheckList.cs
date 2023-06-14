public class Checklist : CreateGoal{

    public Checklist( List<string> _goals , int _score):base(_goals, _score){
  
    }
    public Checklist(){

    }

    public string CreateCheckGoal(){
       
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("What is a sort description of it?");
        string description= Console.ReadLine();

        Console.WriteLine("What is the amount of poins associated with this goal?");
        string score= Console.ReadLine();

        Console.WriteLine("How many times does this goal need to be accomplish for a bonus?");
        string timestobedone= Console.ReadLine();

        Console.WriteLine("What is the the bonus for accomplishing it many time?");
        string bonus= Console.ReadLine();

        int timesdone= 0;

        string simpleGoal = $"Checklist:{name},{description},{score},{score},{bonus},{timestobedone},{timesdone};";

        return simpleGoal;

    }

    public void AddCheckCompleted(){

    }

    public override void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string[] sentence = _goals[i].Split(';');
            string name = sentence[0];
            string description = sentence[1];
            string timestobedone = sentence[6];
            string timesdone = sentence[7];
           

            string formatted = $"{i + 1}. [] {name} ({description}) -- Current Completed {timestobedone}{timesdone}";
            Console.WriteLine(formatted);
        }
    }

}