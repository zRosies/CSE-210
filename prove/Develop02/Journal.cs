class Journal{
    public static Entry _useren= new Entry();
    string _userChoice;
    string _csv;
    
    public void Displayprompt(){
        _useren.RandomPrompt();

    }
    public void DisplayEntries(){
        foreach(string line in _useren._UserEntries){
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

            _useren._UserEntries.Add(line);

        }
    }
    public void SaveToFile(){
        Console.WriteLine("Enter your File name: ");
        string _csv =  Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_csv))
        {
            // You can add text to the file with the WriteLine method
            foreach(string line in _useren._UserEntries){
                outputFile.WriteLine(line);
            }

        }


    }
    public void EraseJournal(){
        Console.Write("Write the number of the line you want to remove: ");
        string userchoice=Console.ReadLine();
        _useren.Erase(userchoice);

    }

}