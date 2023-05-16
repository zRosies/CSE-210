public class Fraction{
	private int _top;
	private int _bottom;
	
	public Fraction(){
		_bottom =1;
		_top=1;
	}

	public Fraction(int top){
		_top = top;
		_bottom = 1;
	}
	public Fraction (int top, int bottom){
		_top = top;
		_bottom= bottom;
	}
	
	public int Top{
		get{ return _top;}
        set {_top = value ;}
	}
	public int Bot{
        get{ return _bottom;}
        set{ _bottom = value;}
    }
	public string GetFractionString(){
	    string result = _top.ToString()+"/"+_bottom.ToString();
        return result;
         
	}
	public double getDecimal(){
        double result = (double) _top/_bottom;
        return result;
	}
}

 
