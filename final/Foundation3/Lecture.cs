class Lecture:Event{
    private string _speaker;
    private int _capacity;
    public Lecture(string speaker, int capacity, string _title,string _description, string _date,string _time, string _address): base(_title, _description, _date, _time,_address){
        _speaker=speaker;
        _capacity=capacity;

    }
    public Lecture(){}
    public string LectureFullDetail(){
        return $"\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nSpeaker: {_speaker}\nCapacity: {_capacity}/100";
    }

}