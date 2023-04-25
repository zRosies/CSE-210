using System;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = numbers= new List<int>();
        int number=-1;
        while(number != 0){
        Console.Write("Enter a number: ");
        string user=Console.ReadLine();
        number=int.Parse(user);
        numbers.Add(number);
       
        }
         foreach(int num in numbers){
            int sum=0;
            sum+=num;
            Console.Write(sum);
            }

        
    }
}