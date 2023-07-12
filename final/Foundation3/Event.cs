class Event{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    private string _eventType;

    public Event(string title,string description, string date,string time, string address){
        _title=title;
        _description=description;
        _date=date;
        _time=time;
        _address=address;
    }   
    public Event(){

    }
    public string getSetEventType{
        get{return _eventType;}
        set{_eventType=value;}
    }


    public string StandartDetails(){

        return $"\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }
    public string ShortDetails(){
        return $"\nEvent: {_eventType}\nTitle: {_title}\nDate: {_date}";
    }


}