public class Assignments{
    protected string _studentsName = "";
    protected string _topic ="";

    public Assignments (string studentName, string topic){
        _studentsName= studentName;
        _topic=topic;
    }

    public Assignments(){
        _studentsName="unknown";
        _topic="unknown";
    }


    // the way are learning
    public string getstudentName(){
        return _studentsName;
    }
    public void setStudentName(string student ){
        _studentsName = student;
    }

    //applying the method
    public string getsettopic{
        get {return _topic;}
        set{ _topic= value;}

    }

    public string getSummary(){
        return $"{_studentsName} - {_topic}";
    }


}