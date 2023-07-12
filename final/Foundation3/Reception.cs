class Reception:Event{
    private string _email;

    public Reception(string _title,string _description, string _date,string _time, string _address, string email): base(_title, _description, _date, _time,_address){
        _email=email;
    }
    public Reception(){}
    
    public string ReceptionFullDetail(){
        return $"\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nRSPV Email: {_email}";
    }
}