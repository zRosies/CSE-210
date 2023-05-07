using System;

class Program
{
    static void Main(string[] args){
        Job person1= new Job();
        person1._company="Microsoft";
        person1._jobtitle="Software Engineer";
        person1._startyear=2019;
        person1._endyear=2022;

        Job person2 = new Job();
        person2._company="Apple";
        person2._jobtitle="Manager";
        person2._startyear=2022;
        person2._endyear=2023;

        person1.Display();
        person2.Display();
        
        Resume myresume = new Resume();
        myresume._name="Alisson Rose";
        myresume._jobs= new List<Job>();
        myresume._jobs.Add(person1);
        myresume._jobs.Add(person2);
        myresume.Displayall();
    }
}