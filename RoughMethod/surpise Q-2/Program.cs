using System;
using System.Data.Common;
using System.Linq;
namespace Surprise;
class Program
{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
                int sum=0;
                int i=1;
                while(i<n)
                {
                  if(i%2==0&&sum<n-1)
                   {
                     sum=i*5;
                     Console.WriteLine(sum);
                    } 
                    i++;
                
                }     
                
            
                // Write your logic here
    }
}
