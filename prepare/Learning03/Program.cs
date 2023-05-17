using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction output = new Fraction();
        output.Top=1;
        Console.Write(output.GetFractionString());
        Console.Write("\n");
        Console.Write(output.getDecimal());
        Console.Write("\n");

        output.Top=5;
        Console.Write(output.GetFractionString());
        Console.Write("\n");
        Console.Write(output.getDecimal());
        Console.Write("\n");
        
        output.Top=3;
        output.Bot=4;
        Console.Write(output.GetFractionString());
        Console.Write("\n");
        Console.Write(output.getDecimal());
        Console.Write("\n");
        
        output.Top=1;
        output.Bot=3;
        Console.Write(output.GetFractionString());
        Console.Write("\n");
        Console.Write(output.getDecimal());
      
    }
}