class Product{
    private int _value=0;
    private Dictionary<string, (int price, string id)> productData = new Dictionary<string, (int, string)>()
    {
        {"Laptop", (800, "ID-987654")},
        {"Desktop computer", (1200, "ID-123456")},
        {"Smartphone", (700, "ID-789012")},
        {"Tablet", (500, "ID-345678")},
        {"Monitor", (200, "ID-901234")},
        {"Keyboard", (50, "ID-567890")},
        {"Mouse", (30, "ID-234567")},
        {"Printer", (150, "ID-890123")},
        {"External hard drive", (100, "ID-456789")},
        {"Router", (80, "ID-012345")}
    };

    public void DisplayStoreItems(){
        int count=1;
        foreach (var product in productData)
            {
                string productName = product.Key;
                int productPrice = product.Value.price;
                string productID = product.Value.id;
                // int productQuantity=product.Value.quantity;

                // Do something with the productata
                Console.WriteLine($"{count}. Product: {productName}, Price: {productPrice}, {productID}.");
                count++;
            }
    }

    public string PassItem(string item){
       
        int itemIndex=int.Parse(item);
        itemIndex--;
        string[] productNames = productData.Keys.ToArray();
        string productName = productNames[itemIndex];
        int productPrice= productData[productName].price;
        string productID= productData[productName].id;
        
        Console.WriteLine(productName);
        Console.WriteLine("Enter the quantity: ");
        string quantity= Console.ReadLine();
        int quantitymod= int.Parse(quantity);
        CalculateOrder(productPrice,quantitymod);
        
        return $"|{productName}({productID}): ${productPrice} ---  x{quantity}|";
    }


    public void CalculateOrder(int price, int quantity){
        _value=price*quantity; 

    }

    public int PassValue(){
        return _value;
    }


    // public string AddItem(){

    // }



}