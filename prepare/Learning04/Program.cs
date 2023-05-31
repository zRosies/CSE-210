using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments test = new Assignments();
        test.setStudentName("Gustavo");
        test.getsettopic="The worst things happening in Brazil";
        Console.WriteLine(test.getSummary());

        MathAssignment test1 = new MathAssignment();
        test1.setStudentName("Apolo");
        test1.getsettopic="First arrival at the moon";
        test1.getsetTextbook= "Section 7.3";
        test1.getsetProblems = "Problems 8-19";
        Console.WriteLine(test1.GetHomeworkList());

        WrittingAssignment test2 = new WrittingAssignment();
        test2.setStudentName("Anna");
        test2.getsettopic="European History";
        test2.getSetTitle="The Causes of World War II by Mary Waters";
        Console.WriteLine(test2.getWrittingInformation());

    }
}