using System;
using System.Diagnostics.CodeAnalysis;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number1");
        int start=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number2");
        int end=int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=start;i<=end;i++)
        {
            sum+=i*i;
        }    
        Console.WriteLine("sum="+sum);
    
    }
}
