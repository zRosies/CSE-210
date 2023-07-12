using System;

class Program
{
    static void Main(string[] args)
    {
        string[] menu ={"1. Lecture","2. Reception","3. Outdoor","4. Exit"};

        Address Address= new Address();
        string lecAddress= Address.getSetAddress="Googy 23 Street";
        string recpAddress=Address.getSetAddress="Aloha 19 Street";
        string outAddress= Address.getSetAddress="Joyhover 14 Street";
     
        Lecture lecture= new Lecture("John",56,"The Power of the Water", "Lecture displaying the importance of the water","22.05.2023", "7:00 p.m",lecAddress);
        Reception reception= new Reception("The Art of Liberty","A marvelous speech about freedom","05.10.2023","9:00 a.m",recpAddress, "ReceptionEvent@gmail.com");
        Outdoor outdoor= new Outdoor("Easiest ways of losing money","A seminary about finances","24.11.2023","3:00 p.m",outAddress, 77);
        lecture.getSetEventType="Lecture";
        reception.getSetEventType="Reception";
        outdoor.getSetEventType="Outdoor";
        string user="";
        do{
            Console.WriteLine("");
            foreach(string line in menu){
                Console.WriteLine(line);
            }
            Console.WriteLine("Which option do you want to display: ");
            user =Console.ReadLine();
            if(user=="1"){
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine(lecture.StandartDetails());
                    Console.WriteLine("\n------------------------------------------------------------");
                    Console.WriteLine(lecture.LectureFullDetail());
                    Console.WriteLine("\n----------------------------------------------------------");
                    Console.WriteLine(lecture.ShortDetails());
                    Console.WriteLine("\n------------------------------------------------------------");

            }
            else if(user=="2"){
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine(reception.StandartDetails());
                Console.WriteLine("\n------------------------------------------------------------");
                Console.WriteLine(reception.ReceptionFullDetail());
                Console.WriteLine("\n----------------------------------------------------------");
                Console.WriteLine(reception.ShortDetails());
                Console.WriteLine("\n------------------------------------------------------------");


            }
            else if(user=="3"){
                
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine(outdoor.StandartDetails());
                Console.WriteLine("\n------------------------------------------------------------");
                Console.WriteLine(outdoor.OutdoorFullDetail());
                Console.WriteLine("\n----------------------------------------------------------");
                Console.WriteLine(outdoor.ShortDetails());
                Console.WriteLine("\n------------------------------------------------------------");
                
            }
            else if(user=="4"){
                Console.WriteLine("Thanks for comming");
            }
            else{
                Console.WriteLine("Choose a number within the menu.");
            }
        }while(user!="4");
    



        
    }

     
}