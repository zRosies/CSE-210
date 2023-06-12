class Square : Shape{
    private double _side = 0;

    public double getSetSide{
        get{return _side;}
        set{_side=value;}

    }

    public override double getArea()
    {
        return _side*_side;
    }

}