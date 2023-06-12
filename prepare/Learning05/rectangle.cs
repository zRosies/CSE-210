class Rectangle : Shape{
    private double _length=0;
    private double _width=0;

    public double getSetLength{
        get{return _length;}
        set{_length=value;}
    }

    public double getSetWidth{
        get{return _width;}
        set{_width=value;}
    }

    public override double getArea()
    {
        return _length*_width;
    }

}