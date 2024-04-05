using System;
namespace TypeConversion;
class Program
{
	public static void Main(string[] args)
	{
		
		Console.Write("Enter your name: ");
		string name = Console.ReadLine();
		Console.Write("enter your age:");
		int age = int.Parse(Console.ReadLine());
		Console.Write("Enter mark of subject1:");
		int sub1 = int.Parse(Console.ReadLine());
		Console.Write("Enter mark of subject2:");
		int sub2 = int.Parse(Console.ReadLine());
		Console.Write("Enter mark of subject3:");
		int sub3 = int.Parse(Console.ReadLine());
		Console.Write("Enter Grade:");
		char temp = char.Parse(Console.ReadLine());
		Console.Write("enter the Mobile Number:");
		long num = long.Parse(Console.ReadLine());
        Console.Write("Enter the Email id:");
		string mail=Console.ReadLine();
		Console.WriteLine("------------------------------------------------------");

        Console.WriteLine("Trainee Details are");
        Console.WriteLine("Name: "+name);
		Console.WriteLine("Age: "+age);
		Console.WriteLine("Mobile Number: "+num);
		Console.WriteLine("Mark1: "+sub1);
		Console.WriteLine("Mark2: "+sub2);
		Console.WriteLine("Mark3: "+sub3);
		Console.WriteLine("Total: "+(sub1+sub2+sub3));
		Console.WriteLine("Average: "+(sub1+sub2+sub3)/3);
		Console.WriteLine("Mail: "+mail);
    }
	
}
