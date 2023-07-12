class Swimming:Activity{
    private float _numberOfLaps;
    private float _distance;
    private float _speed;
    private float _pace;
    
    public Swimming(float numberOfLaps, string date, float minutes, string actName):base(date, minutes, actName){
        _numberOfLaps=numberOfLaps;
    }

    private void CalculateDistance(){
        _distance=_numberOfLaps*50/1000;
    }
    // private void CalculateSpeed(){
    //     _speed=(_distance/_minutes)*60;
    // }
    private void CalculatePace(){
        _pace=_minutes/_distance;
    }

    private void CalculateSpeed(){
        _speed=60/_pace;
    }

    public override string GetSummary()
    {
        // CalculateSpeed();
        CalculateDistance();
        CalculatePace();
        CalculateSpeed();
        float formSpeed= (float)Math.Round(_speed,2);
        float formDistance= (float)Math.Round(_distance,2);
        float formPace= (float)Math.Round(_pace,2);
       return $"{_date} {_actName} ({_minutes} min) - Number of Laps: {_numberOfLaps} | Distance: {formDistance} Km | Speed: {formSpeed} km/h | Pace: {formPace} per Kilometer";
    }

}