using System;

namespace Ques1Ass;
class Program 
{
    public static void Main(string[] args)
    {
       int[]str1=new int[5]{1,1,3,0,5};
      //for(int i=0;i<n;i++)
        //int n1=Convert.ToInt32(Console.ReadLine());
        //str1=n1;
        //Console.WriteLine(i);
      for (int i=0;i<=str1.Length;i++)
      {
            if(str1[i]<=str1[i+1])
                Console.WriteLine(str1[i+1]);
            else
                Console.WriteLine(str1[i]);
      }
         // for (int i=0;i<=n;i++)
    }
                 
}