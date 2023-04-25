using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        List<float> numbers = numbers= new List<float>();
        float sum=0;
        float avg=0;
        float num_list=0;
        float larg=0;
        int number=-1;
        float small= 9999;
        while(number != 0)
        {
            Console.Write("Enter a number: ");
            string user=Console.ReadLine();
            number=int.Parse(user);
            if (number!=0)
            {
            numbers.Add(number);
            }
        }
     ;
        foreach(float num in numbers){
            if(num>larg)
            {
                larg=num;
            }
            sum+=num;
            if (num < small && num > 0){
                small=num;
            }
        }
            num_list=numbers.Count();
            avg=sum/num_list;
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {avg}");
            Console.WriteLine($"The larges number is: {larg}");
            Console.WriteLine($"The larges number is: {small}");
            numbers.Sort();
            foreach(float num in numbers){
                Console.WriteLine($"The sum is: {num}");

            }


        
    }
}