public class ReflectingActivity
 : Activity{
    
    private string[] _randomPrompts={"How was your first kiss?", "When was the worst NO of your life?",
    "Think of a time when you did something really difficult!", "How was your first day at the school?",
    "How was your first day at the university?", "How was when you broke your heart for the first time?", 
    "Think of a time when you got really frustrated!"};
    private string[] _fixedQuestions={"How did you feel about that experience?",
    "How did you feel when it was complete?", "Did you miss that experience?", 
    "How was that experience relevant to you?", "What did you learn with this experience?",
    "What was the best thing about that experience?"};
    public ReflectingActivity
    (){
        _activityDuration=0;
        
    }
    public ReflectingActivity
    (int _activityDuration, string _activityName, string _description): base(_activityName,_description, _activityDuration){

    }

public void renderFixedQuestion()
{
    Console.WriteLine();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_activityDuration);
    List<int> repetition = new List<int>();

    do
    {
        Random fixedQuestion = new Random();
        int fixedRandom;

        do
        {
            fixedRandom = fixedQuestion.Next(0, _fixedQuestions.Length);
        }
        while (repetition.Contains(fixedRandom));

        string phrase = _fixedQuestions[fixedRandom];
        Console.WriteLine($"> {phrase}");
        animation(5);
        repetition.Add(fixedRandom);
        startTime = DateTime.Now;
    }
    while (startTime < endTime);
}
    public void promptRandomQuestions(int activityDuration){
        Console.WriteLine("\nConsider the following prompt:");
        Random random = new Random();
        int randomPick= random.Next(0,_randomPrompts.Length);
        string randomPhrase=(_randomPrompts[randomPick]);
        Console.WriteLine($"\n--- {randomPhrase} ---");

        Console.Write("\nWhen you have something in mind press enter to continue: ");
        Console.ReadLine();
        Console.Write("\nNow ponder on each of the following questions as they related to this experience");
        Console.Write("\nYou may begin in: ");
        countDown(5);
        renderFixedQuestion();
    }

    
     
}