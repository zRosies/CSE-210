class Order{
   private bool _country=false;
   private int _value=0;
   private List<string> customerOrder= new List<string>();

   public bool getSetCountry{
      get{return _country;}
      set{_country=value;}
   }
   public int getSetValue{
      get{return _value;}
      set{_value=value;}
   }

   public void AddItems(string item){
         customerOrder.Add(item);
         Console.WriteLine("Item Added.");
   }

   public void IssuePackingLabel(string addres){
      Console.WriteLine("\n");
      Console.WriteLine("------------------------------------------------------------------------");
      foreach(string lin in customerOrder){
          Console.WriteLine(lin);
      }
      
      if(_country){
         Console.WriteLine("\nShipping Cost: $5");
         _value+=5;
      }
      else{
         Console.WriteLine("\nShipping Cost: $35");
         _value+=35;
      }
     
      Console.WriteLine($"Total: ${_value}.");

      Console.WriteLine(addres);
      Console.WriteLine("\n------------------------------------------------------------------------");
   }
   public void Display(){
      foreach(string lin in customerOrder){
          Console.WriteLine(lin);
      }
   }

   public void IssueShippingLabel(string address){
      Console.WriteLine("------------------------------------------------------------------------");
      Console.WriteLine($"{address}");
      Console.WriteLine("\n------------------------------------------------------------------------");

   }


}