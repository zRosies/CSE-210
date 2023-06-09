class FocusActivity : Activity{
    private string[] _questions={"How much is 3x7?","What's the capital of England?",
    "What's the disciple who betrayed Jesus?", "Who created the lightball?",
    "When the first world war began?", "What prophet openned the red sea?", "How much is 17+16?",
    "What is the name of Laman's Father?", "What's the capital of Frace?", "What is the capital of Brazil?",
    "Who discovered the Americas?",""};
    private string[] _asnwers={"21", "LONDON","JUDAS","THOMAS EDSON", "1914", "MOSES", "33",
    "LEHI", "PARIS", "BRASILIA","Christopher Columbus"};
    public FocusActivity(){

    }
    public FocusActivity( string _activityName, string _description, int _activityDuration) : base(_activityName, _description, _activityDuration){

    }

    private void RenderQuestions(){

        Random random= new Random();
        
        List<int> repetition= new List<int>();
        DateTime startTime= DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);
        int count = 0;
        int questions=0;

        do{
        int index = random.Next(0, _questions.Length);
        bool isRepeated = false;

        //Trygin to avoid repetition
        foreach (int line in repetition)
        {
            if (line == index)
            {
                isRepeated = true;
                break;
            }
        }

            if (!isRepeated)
            {
                repetition.Add(index);

                string phrase = _questions[index];
                Console.WriteLine($"> {phrase}");
                animation(1);
                string user = Console.ReadLine();
                
                user = user.ToUpper();

                startTime = DateTime.Now;
                string answer = _asnwers[index];
                if (user == answer)
                {
                    count++;
                }

                questions++;
            }
    } while (startTime < endTime);

    Console.WriteLine($"\nYou have made {count} out of {questions}!");
}



    public void RenderFocusActivity(){
        Console.WriteLine("\nMaintain your focus to answer as many questions as you can!");
        Console.WriteLine("You main begin in: ");
        countDown(5);
        RenderQuestions();
    }
    


}