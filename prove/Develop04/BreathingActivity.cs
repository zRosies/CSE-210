public class BreathingActivity : Activity{
    public BreathingActivity(){
        _activityDuration=0;
        
    }
    public BreathingActivity(int _activityDuration, string _activityName, string _description): base(_activityName,_description, _activityDuration){

    }



    public void Breathing(){
        DateTime startTime= DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);
        Console.Write("\b \b");

        do{
         
            Console.WriteLine("\nBreathe in...");
            int divider =4;
            int divider2= 5;
            if (_activityDuration > 30){
                divider=8;
                divider2=9;
            }

            countDown(_activityDuration/divider);
          
           
            Console.WriteLine("Now breathe out...");
            countDown(_activityDuration/divider2);
            startTime = DateTime.Now;
        }while(startTime < endTime); 



    } 

}

