class Entry{
    public List<string> _userEntries = new List<string>();
    string _userEntry;
    private object _prom;

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
        
        _prom=(prompts[index]);
        Console.WriteLine(_prom);
        useranswer=Console.ReadLine();
        DateTime date = DateTime.Now;
        string currentdate = date.ToShortDateString();
        int newline = _userEntries.Count +1;
        _userEntry=($". Date: {currentdate} - Prompt: {_prom} \n{useranswer} ");
        StoreEntries(_userEntry);      
    }
    
    public void StoreEntries(string _userEntry){
       _userEntries.Add(_userEntry);
      
    }
    public void Erase(string number){
        //Removes the index lines based on the user choice
        int choice = int.Parse(number);
        for(int i =0;i < _userEntries.Count; i ++){
            if(choice == i){
                _userEntries.Remove(_userEntries[i-1]);
    
                
            }

        }
        

    } 
    
    

}