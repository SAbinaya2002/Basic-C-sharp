using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
                int N=int.Parse(Console.ReadLine());
                string[] str=new string[N];
                int[] int1=new int[str.Length];
                for(int i=0;i<=N;i++)
                   str[i]=Console.ReadLine();
                for(int i=0;i<=str.Length;i++)
                   int1[i]=int.Parse(Console.ReadLine());
                int AddElem=Sumofvalues(int1[]);
                Console.WriteLine(AddElem);
        }
    static int Sumofvalues(int num);
            {
                int sum=0;
                foreach(int n in num)
                    sum=sum+n;
                return sum;
            }
    }
}