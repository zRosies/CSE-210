public class Scriptures{
    private List<string> _ScriptList= new List<string>(); 
    private string _Scriptures;
    private string _References;
    private string _sentence;

    public Scriptures(){
		_Scriptures ="";
		_References="";
	}

	public Scriptures(string reference){
		_References = reference;
		_Scriptures = "";
	}
	public Scriptures (string reference, string Sentences){
		_References =reference;
		_Scriptures= Sentences;
	}

    //This allows the user to add scriptures and references
    public string GetAndSetScripture{
        get{return _Scriptures;}
        set{_Scriptures = value;}
    }


    public string GetAndSetReference{
        get{return _References;}
        set{_References = value;}
    }
    // ------------------------------------------------//
    
    public void AddSentence(string Reference, string Scripture){
        _References=Reference;
        _Scriptures= Scripture;
        int index = _ScriptList.Count + 1;
        _sentence = $"{index}. {Reference}; {Scripture} ";
        _ScriptList.Add(_sentence);
    }

    public void Displaylist(){
        foreach (string sentence in _ScriptList)
        {
            Console.WriteLine(sentence);
        }
    }
    //This breaks the whole text (John 3:17: Scripture......) getting info from the list//
    public string BreakSentence( string user){
        int index= int.Parse(user);
        index-=1;

        string _UserString = _ScriptList[index];
        string[] scriptSentenceParts = _UserString.Split(";");
        string scriptSentence = scriptSentenceParts[1].Trim();
        

        return scriptSentence;
            
    }
    public string BreakReference(string user){
       
        int index= int.Parse(user);
        index-=1;
        string _UserString = _ScriptList[index];
        string[] scriptSentenceParts = _UserString.Split(";");
        string refSentence = scriptSentenceParts[0].Trim();
        

        return refSentence;
    }
    //------------------------------------------------------------------//

    public List<string> List(){
        return _ScriptList;
    }


}

