using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        int n=Convert.ToInt32(Console.ReadLine());
                string[] str=new string[n];
                int[] int1=new int[str.Length];
                string odd=string.Empty;
                string even=string.Empty;
                for(int i=0;i<n;i++)
                {
                    str[i]=Console.ReadLine();
                    int1[i]=int.Parse(str[i]);
                    

                }
                for(int i=0;i<n;i++)
                if(int1[i]%2==0)
                    {
                        even +=int1[i]+" ";
                    }   
                    else
                    {
                        odd +=int1[i]+" "; 
                    }
               Console.WriteLine($"Odd Numbers: {odd} ");
               Console.WriteLine($"Even Numbers: {even}");
                
    }
}
