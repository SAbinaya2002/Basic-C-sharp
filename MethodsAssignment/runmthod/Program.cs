using System;
namespace runMethod;
class Program{
    public static void Main(string[] args)
    {
       //string input=Console.ReadLine();
                DateTime date;
                if(DateTime.TryParseExact(Console.ReadLine()," yyyy/MM/dd HH:mm:ss.fff",null,System.Globalization.DateTimeStyles.None,out date))
                    Console.WriteLine("year = "+date.ToLongDateString());
                    //Console.WriteLine("month ="+date.Month);
                    //Console.WriteLine("day ="+date.Day);
                    Console.WriteLine("hour ="+date.Hour);
                    Console.WriteLine("minute ="+date.Minute);
                    Console.WriteLine("second = "+date.Second);
                    Console.WriteLine("millisecond = "+date.Millisecond);
                
    }
}
