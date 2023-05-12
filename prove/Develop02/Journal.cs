class Journal{
    public static Entry _userEnt= new Entry();
    string _userChoice;
    string _csv;
    
    public void Displayprompt(){
        _userEnt.RandomPrompt();

    }
    public void DisplayEntries(){
        foreach(string line in _userEnt._userEntries){
            Console.WriteLine(line);
        }
 
    }
    public void LoadCsvFile(){
        Console.WriteLine("Enter your File name: ");
        string _csv =  Console.ReadLine();
        string content = File.ReadAllText(_csv);
        //Reading the place where the line breaks
        string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        foreach(string line in lines){

            _userEnt._userEntries.Add(line);

        }
    }
    public void SaveToFile(){
        Console.WriteLine("Enter your File name: ");
        string _csv =  Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_csv))
        {
            //Adding text into the List
            foreach(string line in _userEnt._userEntries){
                outputFile.WriteLine(line);
            }

        }


    }
    public void EraseJournal(){
        Console.Write("Write the number of the line of the journal you want to remove: ");
        string userchoice=Console.ReadLine();
        _userEnt.Erase(userchoice);

    }

}