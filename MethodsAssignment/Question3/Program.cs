using System;
using System.Globalization;
namespace Question3;
class Program
{
        static int Sumofvalues(int[] num)
              { 
                int sum=0;
                for (int i=0;i<num.Length;i++)
                    sum=sum+num[i];
                return sum;
              }  
            public static void Main(string[] args)
            {
                int N=int.Parse(Console.ReadLine());
                // string[] str=new string[N];
                int[] int1=new int[N];
                // for(int i=0;i<=n;i++)
                //    str[]=Console.ReadLine();
                for(int i=0;i<N;i++){
                   int1[i]=int.Parse(Console.ReadLine());}
                //int AddElem=Sumofvalues(int1);
                Console.WriteLine(Sumofvalues(int1));
            }

    
}
