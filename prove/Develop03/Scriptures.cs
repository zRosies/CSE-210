public class Scriptures{
    private List<string> ScriptList= new List<string>(); 
    private string _Scriptures;
    private string _References;


    public string GetAndSetScripture{
        get{return _Scriptures;}
        set{_Scriptures = value;}
    }


    public string GetAndSetReference{
        get{return _References;}
        set{_References = value;}
    }
    public void ScripturesAndRef(string reference, string Scripture){
        _References=reference;
        _Scriptures= Scripture;
    }

    
    



}