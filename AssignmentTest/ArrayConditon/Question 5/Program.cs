using System;
namespace Question5;
class Program{
                          
            public static void Main(string[] args)
            {
                int N=int.Parse(Console.ReadLine());
                
                int[] int1=new int[N];
                // for(int i=0;i<=n;i++)
                //    str[]=Console.ReadLine();
                for(int i=0;i<N;i++)
                   int1[i]=int.Parse(Console.ReadLine());
                //int AddElem=Sumofvalues(int1);
                int temp=0; 

                for(int i=0;i<int1.Length;i++)
                   for(int j=0;j<int1.Length;j++)
                        if(int1[i]>int1[j])
                            

                
            }
}
