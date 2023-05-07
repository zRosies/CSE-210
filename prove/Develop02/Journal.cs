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
        string[] lines = System.IO.File.ReadAllLines(_csv);
        foreach(string line in lines){
            string[] parts = line.Split(",");
            string part= parts[0];
            _useren._UserEntries.Add(part);

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

}