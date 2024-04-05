using System;
namespace TypeConversion;
class Program
{
	public static void Main(string[] args)
    {
        int mark=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the mark: ");
        if(mark>=80)
        {
            Console.WriteLine("Grade A");
        }
        else if (mark<80&&mark>61)
        {
            Console.WriteLine("Grade B");
        }
        else if(mark<60&&mark>36)
        {
            Console.WriteLine("Grade C");
        }
        else if(mark<36)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("invalid input");
        }

    }
}


