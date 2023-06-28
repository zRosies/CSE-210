class Address{
    private string _address="";
    private bool _country= false;

    public string GetUserInfo(){
        Console.WriteLine("\nWrite your street adress: ");
        string street= Console.ReadLine();
        Console.WriteLine("Write your city: ");
        string city= Console.ReadLine();
        Console.WriteLine("Write your state/provice: ");
        string state= Console.ReadLine();

        Console.WriteLine("Write your country: ");
        string country= Console.ReadLine();
        country.ToLower();

        if(country=="usa"|| country=="the united states of america"){
            _country=true;
        }
        
        _address=$"{street},{city},{state},{country}";

        return _address;
    }

    public bool isUsa(){
        return _country;
    }
}