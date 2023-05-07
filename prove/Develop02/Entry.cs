class Entry{
    public List<string> _UserEntries = new List<string>();
    string _userentry;
    private object prom;

    public void RandomPrompt(){
        string useranswer="";
        string[] prompts = {
            "What was the best part of my day? ",
            "What made me feel angry today? ",
            "What was worst thing of my day? ",
            "What was something I was grateful for? ",
            "Write something about today you will want to remember in tens years: "
        };
        Random randompick = new Random();
        //Chooses a random index between 0 and the prompt length
        int index = randompick.Next(0,prompts.Length);
        
        prom=(prompts[index]);
        Console.WriteLine(prom);
        useranswer=Console.ReadLine();
        DateTime date = DateTime.Now;
        string currentdate = date.ToShortDateString();
        _userentry=($"Date: {currentdate} - Prompt: {prom}: \n{useranswer}");
        StoreEntries(_userentry);      
    }
    
    public void StoreEntries(string _userentry){
       _UserEntries.Add(_userentry);
      
    } 
    
    

}