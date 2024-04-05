using System;
using System.Diagnostics.CodeAnalysis;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        string str=Console.ReadLine();
        string[]str1=str.Split(",");
        int[] int1=new int[n];
        int sum1=0;
        int sum2=0;
        for(int i=0;i<n;i++)
        {
            int1[i] =int.Parse(str1[i]);
        }
        
        for(int i=0;i<3;i++)
        {
            sum1+=int1[i];
        }
        for(int j=int1.Length;j>3;j--)
        {
            sum2+=int1[j];
        }
        
       if(sum1==sum2)
            Console.WriteLine("1");
        else
            Console.WriteLine("0");

    }
}
