public class MathAssignment : Assignments{
    private string _textbookSection = "";
    private string _problems = "";

    public  MathAssignment(string textbook, string problems, string studentName, string topic) : base(studentName, topic){
            _textbookSection=textbook;
            _problems=problems;

    }
    public MathAssignment(){
        _textbookSection="unknown";
        _problems="unknown";
    }

    public string getsetTextbook{
        get{return _textbookSection;}
        set{_textbookSection=value;}
    }
    public string getsetProblems{
        get{return _problems;}
        set{_problems=value;}
    }

    public string GetHomeworkList(){
        return $"\n{_studentsName} - {_topic}\n{_textbookSection} {_problems}" ;

    }


}