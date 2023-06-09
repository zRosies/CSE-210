public class Activity{
    protected string _activityName  = "";
    protected string _description="";
    protected int _activityDuration=0;

    public Activity(){
        _activityName = "";
        _description="";
        _activityDuration=0;

    }

    public Activity(string name, string description, int activityDuration){
        _activityName = name;
        _description= description;
         _activityDuration=activityDuration;
    }

    public string getSetActivityName{
        get{ return _activityName ;}
        set{ _activityName =value;}
        
    }
    public string getSetDescription{
        get{return _description;}
        set{ _description=value;}

    }
    public int getSetActivityDuration{
        get{return _activityDuration;}
        set{_activityDuration=value;}
    }

    public void animation(int animationduration ){
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(animationduration);
        do{
                Console.Write("|");

                Thread.Sleep(400);
                Console.Write("\b \b"); 
                Console.Write("/");

                Thread.Sleep(400);
                Console.Write("\b \b"); 
                Console.Write("-");

                Thread.Sleep(400);
                Console.Write("\b \b"); 
                Console.Write("\b \b");
            start=DateTime.Now;

        } while(DateTime.Now < end);


    }

    public int startingMessage(){
        Console.WriteLine($"\nWelcome to the {_activityName }\n \n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session?");
        string timer= Console.ReadLine();
        int timerint= int.Parse(timer);
        // Console.WriteLine("Get ready...");
        // animation(5);

        return timerint;


 
    }

    public void startEndingMessage(){
        Console.WriteLine($"\nWell Done!");
        animation(2);
        Console.WriteLine($"\nYou have completed {_activityDuration} seconds of the {_activityName }!");
        animation(2);
    } 

    public void countDown(int countdown){
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(countdown);
       do{
        Console.Write(countdown);
        countdown-=1;   
        Thread.Sleep(1000);
        
        Console.Write(new string('\b', countdown.ToString().Length));
        Console.Write(new string(' ', countdown.ToString().Length));
        Console.Write(new string('\b', countdown.ToString().Length));

        start = DateTime.Now;
    } while(DateTime.Now < end);
        
    }



}

// ordered list
// ul= unordered list
