class Running:Activity{
    private float _distance=0;
    private float _speed=0;
    private float _pace=0;

    public Running(float distance, string date, float minutes, string actName):base(date, minutes, actName){
        _distance= distance;
    }

    private void CalculatePace(){
        _pace=_minutes/_distance;
        
    }
    private void CalculateSpeed(){
        _speed=60/_pace;
        
    }
    

    public override string GetSummary()
     
    {
        CalculatePace();
        CalculateSpeed();
        float formPace= (float)Math.Round(_pace,1);
        float formSpeed= (float)Math.Round(_speed,1);
        
        
        return $"{_date} {_actName} ({_minutes} min) - Distance: {_distance} km | Speed: {formSpeed} km/h | Pace: {formPace} min per km.";
    }
}