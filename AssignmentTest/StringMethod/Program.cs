using System;
namespace StringMethod;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Main String: ");
        string name=Console.ReadLine();
        Console.Write("String to be Searched: ");
        string name2=Console.ReadLine();
        int count=0;
        int last=0;
        while(last!=-1)
        {
            last=name.IndexOf(name2,last);
            if(last!=-1)
            {
                count++;
                last+=name2.Length;
            }
        }
    Console.WriteLine($"String searched count is {count}");
    }
}