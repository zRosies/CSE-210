class Outdoor:Event{
    private int _weather;
    public Outdoor(string _title,string _description, string _date,string _time, string _address,int weather): base(_title, _description, _date, _time,_address){
        _weather=weather;
    }
    public Outdoor(){}

    public string OutdoorFullDetail(){
        return $"\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nForecast: {_weather}° F";
    }
}