class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.getSetColor="blue";
        square.getSetSide=4;

        Rectangle rectangle = new Rectangle();
        rectangle.getSetColor = "red";
        rectangle.getSetLength=2;
        rectangle.getSetWidth=4;

        Circle circle = new Circle();
        circle.getSetColor="yellow";
        circle.getSetRadius=4;

        List<Shape> shape = new List<Shape>();
        shape.Add(circle);
        shape.Add(rectangle);
        shape.Add(square);

        foreach(Shape test in shape){
            double area = test.getArea();
            Console.WriteLine($"Color: {test.getSetColor}; Area: {area.ToString("F2")} ");
        }



    }

}