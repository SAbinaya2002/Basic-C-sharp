using System;
using System.Threading;
namespace Question;
class Program
{
    public static void Main(string[] args)
    {
                int month=int.Parse(Console.ReadLine());
                int year=int.Parse(Console.ReadLine());
                //if(month<=12)
                int days=DateTime.DaysInMonth(year,month));
                Console.WriteLine(days);
    }           
}

              