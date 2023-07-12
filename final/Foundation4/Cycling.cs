class Cycling:Activity{
    private float _speed;
    private float _pace;
    private float _distance;

    public Cycling(float speed, string date, float minutes, string actName):base(date, minutes, actName){
        _speed= speed;
    }

    // public int GetSetSpeed{
    //     get{return _speed;}
    //     set{_speed=value;}
    // }

    private void Distance(){
        _distance=_minutes/_pace;
    }

    private void CalculatePace(){

        _pace= 60/_speed;
    }

    public override string GetSummary()
    {
        CalculatePace();
        Distance();
        float formPace= (float)Math.Round(_pace,1);
        return $"{_date} {_actName} ({_minutes} min) - Distance: {_distance} km | Speed: {_speed} km/h | Pace: {formPace} min per km.";
    }
}