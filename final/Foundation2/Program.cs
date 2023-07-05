using System;

class Program
{
    static void Main(string[] args)
    {
        Product product= new Product();
        Address address = new Address();
        Customer customer = new Customer();
        Order order= new Order();


        Console.WriteLine("\nOnline Ordering Technology Shop");
        Console.WriteLine("Write the customer's name: ");
        customer.getSetName=Console.ReadLine();
        
        string nameAndAdress=customer.nameAndAddress(address.GetUserInfo());
        string[] menu={"\n1. Add item", "2. Display Customer's order", "3. Issue Packing label","4. Issue Shipping Label", "5. Exit"};
        // product.DisplayProducts();
        order.getSetCountry=address.isUsa();
        string user="";
        TextWriter originalConsoleOut = Console.Out;
        do{
            
            foreach(string line in menu){
                Console.WriteLine(line);
            }
            Console.WriteLine("Select an option: ");
            user=Console.ReadLine();
            if(user=="1"){
                product.DisplayStoreItems();
                Console.WriteLine("Select an item: ");
                string item = Console.ReadLine();
                order.AddItems(product.PassItem(item));
                order.getSetValue=product.PassValue();
            
            }
            else if(user=="2"){
                order.Display();

            }
            else if(user=="3"){
                string filePath="Packing Order";
                using (StreamWriter writer = new StreamWriter(filePath)){
                    Console.SetOut(writer);
                    order.IssuePackingLabel(nameAndAdress);
                    Console.SetOut(Console.Out);
                }
                Console.SetOut(originalConsoleOut); 
                Console.WriteLine("Your Packing Order has been issued.");
               
            }
            else if(user=="4"){
                
                string filePath= "Shipping Order";
                using (StreamWriter writer = new StreamWriter(filePath)){
                    Console.SetOut(writer);
                    order.IssueShippingLabel(nameAndAdress);
                    Console.SetOut(Console.Out);
                }
                Console.SetOut(originalConsoleOut);
                Console.WriteLine("Your Shipping Order has been issued.");
              
                
            }
            else if(user == "5"){
                Console.WriteLine("Thanks for comming.");
            }
            else{
                    Console.WriteLine("Choose a number within the menu.");
            }

        }
        while(user!="5");
        
    }
}