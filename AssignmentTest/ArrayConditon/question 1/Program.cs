using System;
using System.Globalization;
namespace Question1;
class Program
{
     public static void Main(string[] args)
     {
         int n=Convert.ToInt32(Console.ReadLine());
                string[] str=new string[n];
                int[]int1=new int[str.Length];
                int sum=0;
                for(int i=0;i<n;i++)
                    str[i]=Console.ReadLine();
                for(int i=0;i<n;i++)
                   int1[i]=int.Parse(str[i]);
                foreach (int num in int1)
                   sum=sum+num;
                Console.WriteLine(sum);
                     
                        
     }
}
