using System;

class Program
{
    static void Main(string[] args)
    {
        string[] menu ={"1. Create Event","2. Display Event"};
        Lecture TEST= new Lecture("John",56,"The Power of the Water", "Lecture displaying the importance of the water","22.05.2023", "7 p.m","Googy 23 Street");
        Reception test2= new Reception("")
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine(TEST.LectureFullDetail());
        Console.WriteLine("\n----------------------------------------------------------");
        
    }
}