class Entry{
    public List<string> _UserEntries = new List<string>();
    string _userentry;
    private object prom;

    public void RandomPrompt(){
        string useranswer="";
        string[] prompts = {
            "What was the best part of your day? ",
            "What made you feel angry today? ",
            "What was worst thing of your day? ",
            "What was something you are grateful for? ",
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
        int newline = _UserEntries.Count +1;
        _userentry=($". Date: {currentdate} - Prompt: {prom} \n{useranswer} ");
        StoreEntries(_userentry);      
    }
    
    public void StoreEntries(string _userentry){
       _UserEntries.Add(_userentry);
      
    }
    public void Erase(string number){
        //Removes the index lines based on the user choice
        int choice = int.Parse(number);
        for(int i =0;i < _UserEntries.Count; i ++){
            if(choice == i){
                _UserEntries.Remove(_UserEntries[i-1]);
    
                
            }

        }
        

    } 
    
    

}