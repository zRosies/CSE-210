class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        int countdown=5;
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(countdown);
        do{
                Console.Write(countdown);
                countdown-=1;   
                Thread.Sleep(1000);
                Console.Write("\b \b"); 
                Console.Write(countdown);
                Console.Write("\b \b"); 
               

        } while(DateTime.Now < end);
    }
}