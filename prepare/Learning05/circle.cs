class Circle : Shape{
    
    private double _radius=0;

    public double getSetRadius{
        get{return _radius;}
        set{_radius= value;}
    }


    public override double getArea()
    {
        return Math.PI*_radius*_radius;
    }

}