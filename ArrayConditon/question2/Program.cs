using System;
using System.Diagnostics.CodeAnalysis;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        int N=int.Parse(Console.ReadLine());
        string[] str=new string[N];
        int[] int1=new int[str.Length];
        int sum=0;
        for(int i=0;i<N;i++)
           str[i]=Console.ReadLine();
        for(int i=0;i<str.Length;i++)
           int1[i]=int.Parse(str[i]);
         for(int i=0;i<int1.Length;i++)
            sum=sum+int1[i];
        Console.WriteLine(sum);
                   //Console.WriteLine(i);
    }
}