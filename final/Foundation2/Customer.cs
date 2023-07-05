class Customer{
    private string _name="";
    
    public string getSetName{
        get{return _name;}
        set{_name=value;}
    }

    public string nameAndAddress(string address){

        return $"\nName: {_name}\n{address}";
    }

    public bool isFromUsa(bool isusa){
        return isusa;

    }


}