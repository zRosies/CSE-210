public class WritingActivity : Activity{
    private string[] _fixedQuestion={"When have you felt the holy ghost this month?", 
    "When did you feel really happy?", "When did you feel truly afraid?", 
    "When did you dance like the night never end?", "When did you feel successful?", "When you felt that you were missing someone?",
    "When did you really feel hungry?", "What would you do if today were your last day?"};
   
    public WritingActivity(int _activityDuration, string _activityName, string _description): base(_activityName,_description, _activityDuration){

    }
    public WritingActivity(){

    }

    private void promptRandomQuestion(){
        Random random= new Random();
        int index= random.Next(0,_fixedQuestion.Length);
        string phrase= (_fixedQuestion[index]);
        Console.WriteLine("\nList as many responses as you can to the following prompt");
        Console.Write($"--- {phrase} ---");
        Console.WriteLine("\nYou may begin in: ");
        countDown(5);
    }

    public void writeExperiences(){
        promptRandomQuestion();
        DateTime startTime= DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);
        do{
            Console.Write("> ");
            Console.ReadLine();
            startTime= DateTime.Now;
        }while(startTime < endTime); 

        

    }


}