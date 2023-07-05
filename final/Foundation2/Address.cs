class Address{
    private string _address="";
    private bool _country= false;

    public string GetUserInfo(){
        Console.WriteLine("\nWrite the customer's street adress: ");
        string street= Console.ReadLine();
        Console.WriteLine("Enter the city: ");
        string city= Console.ReadLine();
        Console.WriteLine("Enter the state/provice: ");
        string state= Console.ReadLine();

        Console.WriteLine("Enter your country: ");
        string coun= Console.ReadLine();
        string countrybol = coun.ToLower();
        string country= coun.ToUpper();

        if(countrybol=="usa"|| countrybol=="the united states of america"){
            _country=true;
        }
        
        _address=$"Address: {street}, {city}, {state}\n{country}";

        return _address;
    }

    public bool isUsa(){
        return _country;
    }
}