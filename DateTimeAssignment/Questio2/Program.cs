using System;
namespace Questionn2;
class Program{
    public static void Main(string[] args)
    {
         string str=Console.ReadLine();
                DateTime  date;
                if(!DateTime.TryParseExact(str,"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out date))
                {
                    return;
                }
                DateTime resultDate=date.AddDays(40);
                Console.WriteLine("Date:"+resultDate.ToString("dd/MM/yyyy"));
                Console.WriteLine("Day:"+resultDate.ToString("dddddddd"));
                // Write your logic here
    }
}
