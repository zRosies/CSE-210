abstract class Shape{
    protected string _color="";

    public string getSetColor{
        get{ return _color;}
        set{_color=value;}
    }

    public abstract double getArea();

}