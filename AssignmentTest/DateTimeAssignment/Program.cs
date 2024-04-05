using System;
namespace DateTimeMethod;
class Program
{
    public static void Main(string[] args)

    {//creating a date time object
        DateTime date=new DateTime(2021,8,10,10,40,32);

        //display invidual component date time
        Console.WriteLine("Year : "+date.Year);
        Console.WriteLine("Month: "+date.Month);
        Console.WriteLine("date: "+date.Date);
        Console.WriteLine("Hour :"+date.Hour);
        Console.WriteLine("Minitues:"+date.Minute);
        Console.WriteLine("seconds: "+date.Second);

        //converting date time to string
        string dateTimeString=date.ToString();

        //splitting string into components
        string[] dateTimeComponents=dateTimeString.Split(new char[]{' ','/',':',' '});

        //printing components in reverse order
        Console.WriteLine("\nOutput :"+ dateTimeComponents[2]+" "+dateTimeComponents[1]+" "+dateTimeComponents[0]+" "+dateTimeComponents[3]+" "+dateTimeComponents[4]+" "+dateTimeComponents[5]);
        Console.WriteLine("\nEnter a date and time(yyyy/MM/dd hh:mm:ss tt):");
        string userInput=Console.ReadLine();
        DateTime userDateTime=DateTime.ParseExact(userInput,"yyyy/MM/dd hh/mm/ss tt",null);

        Console.WriteLine("\nYear :"+userDateTime.Year);
        Console.WriteLine("Month :"+userDateTime.Month);
        Console.WriteLine("Date: "+userDateTime.Date);

    }
}
