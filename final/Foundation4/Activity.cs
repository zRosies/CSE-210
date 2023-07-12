class Activity{
    protected string _date="";
    protected float _minutes=0;
    protected string _actName="";

    public Activity(string date, float minutes, string actName){
        _date=date;
        _minutes=minutes;
        _actName=actName;
    }

    public Activity(){

    }

    public virtual string GetSummary(){
        return "";
    }
}