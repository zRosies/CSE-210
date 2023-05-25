public class Hide{
    private Scriptures ReferenceModified = new Scriptures();
    
        public Scriptures _ReferenceModified
    {
        get { return ReferenceModified; }
    }
    
    //Setting the defaults scriptures witih the list.
    public void setRefDefault(){
        string _reference= "John 3:17";
        string _scripture= "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        string _ref2 = "Proverbs 3:5-6";
        string _scripture2 ="rust in the Lord with all your heart, and do not lean on your own understanding. In all your ways acknowledge him, and he will make straight your paths.";
        string _reference3 = "2 Nephi 2";
        string _scripture3 = "Adam fell that men might be and men care, that they might have joy.";
        _ReferenceModified.AddSentence(_reference,_scripture);
        _ReferenceModified.AddSentence(_ref2,_scripture2);
        _ReferenceModified.AddSentence(_reference3, _scripture3);
    }

    //Adding the users' scripture and reference within the list.
    public void SetSentence(string userRef, string userScripture){
        userRef= _ReferenceModified.GetAndSetReference=$"{userRef}";
        userScripture= _ReferenceModified.GetAndSetScripture=$"{userScripture}";
        _ReferenceModified.AddSentence(userRef,userScripture);

    }

    public void HidePartsOfScripture(string userchoice){
        var random = new Random();
        string reference = _ReferenceModified.BreakReference(userchoice);
        string sentence = _ReferenceModified.BreakSentence(userchoice);
        string[] words= sentence.Split(' ');
        Console.WriteLine($"\n{reference} {sentence}");
        
        int randomIndex;
        string userEntry;
        do{
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish");
            userEntry= Console.ReadLine();
           
            if (userEntry == "quit")
                break;

            //Trying to exit the loop if all words are hidden...//
            bool checking= true;
            foreach (string word in words)
            {
                if (word != new string('_', word.Length))
                {
                    checking = false;
                   
                    break; 
                }
                
            }
            if (checking){
                        userEntry="quit";
                    }
            //----------------------------------//
            
            //It won't repeat the random word//
            do{
                    randomIndex = random.Next(words.Length); 
                    if(words[randomIndex][0]!= '_')
                        break;
                }while(true && checking == false);

            //Replacing the random word with a "_" //  
            for (int i = 0; i < words.Length; i++){
            
                if (i == randomIndex)
                {
                    words[i] = new string('_', words[i].Length);
                    //hidding more than a single word//
                    if( i+3 < words.Length ){
                        words[i+3] = new string('_', words[i].Length);
                        

                    }
                    if(i-2 > words[0].Length)
                    {
                         words[i-2] = new string('_', words[i].Length);
                    }
                    //--------------------------------//
                }
            }   

        string modifiedText = string.Join(" ",reference, string.Join(" ", words));
        Console.WriteLine(modifiedText);
        }while(userEntry != "quit");

    }
    


}