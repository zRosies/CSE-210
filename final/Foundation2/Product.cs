class Product{
    private Dictionary<string, (int price, string id, int quantity)> productData = new Dictionary<string, (int, string, int)>()
    {
        {"Laptop", (800, "ID-987654", 10)},
        {"Desktop computer", (1200, "ID-123456",5)},
        {"Smartphone", (700, "ID-789012",8)},
        {"Tablet", (500, "ID-345678",10)},
        {"Monitor", (200, "ID-901234",5)},
        {"Keyboard", (50, "ID-567890",12)},
        {"Mouse", (30, "ID-234567",3)},
        {"Printer", (150, "ID-890123",2)},
        {"External hard drive", (100, "ID-456789",4)},
        {"Router", (80, "ID-012345",50)}
    };

    public void DisplayProducts(){
        foreach (var product in productData)
            {
                string productName = product.Key;
                int productPrice = product.Value.price;
                string productID = product.Value.id;
                int productQuantity=product.Value.quantity;

                // Do something with the product data
                Console.WriteLine($"Product: {productName}, Price: {productPrice}, Quantity: {productQuantity}, {productID}");
                Console.WriteLine();
            }
    }



}