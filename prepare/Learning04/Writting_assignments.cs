public class WrittingAssignment:Assignments{
    private string _title = "";

    public WrittingAssignment(){
        _title="uknown";
    }
    public WrittingAssignment(string title, string studentName, string topic): base(studentName, topic){
        _title=title;

    }

    public string getSetTitle{
        get{return _title;}
        set{_title=value;}
    }

    public string getWrittingInformation(){
        return $"\n{_studentsName} - {_topic}\n{_title}";
    }
}