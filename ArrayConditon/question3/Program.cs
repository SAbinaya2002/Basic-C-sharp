using System;
namespace nruestion2;
class Program
{
    public static void Main(string[] args)
    {
         int n= int.Parse(Console.ReadLine());
                string[] str=new string[n];
                int[] int1=new int[str.Length];
                
                //Get n num of elements in string array
                for(int i=0;i<n;i++)
                {
                    str[i]=Console.ReadLine();
                }
                   
                //To convert string array to interger array
                for(int i=0;i<str.Length;i++)
                   {
                    int1[i]=int.Parse(str[i]);
                   }
                   int max=int1[0];
                   int min=int1[0];
                for(int i=0;i<int1.Length;i++)
                //for(int i=0;i<int1.Length;i++)
                {
                  
                    if(max<int1[i])
                       max=int1[i];
                    if(min>int1[i])
                       min=int1[i];
                    
                }
                Console.WriteLine("Maximum Element :"+max);
                    
                Console.WriteLine("Minimum Element :"+min);
                // Write your logic here
    }
}