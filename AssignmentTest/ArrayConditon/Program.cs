using System;
using System.Collections.Generic;
namespace ArrayCondition;
class Program
{
  public static void Main(string[] args)
  {
    string[] array={"Mani", "Ganesh", "Venkat", "Suresh", "Venkat"};
    Console.WriteLine("Print the Element in the array");
    for(int i=0;i<=array.Length;i++)
    {
      Console.WriteLine(array[i]);
    }
    Console.Write("Enter the number to get name in array: ");
    int num=int.Parse(Console.ReadLine());

    if(num>=1 && num<=array.Length)
    {
      Console.WriteLine($"The name at the position {num} is {array[num-1]}");
    }
    else
    {
    Console.WriteLine($"The number {num }is out of range");
    }
    
  }
}
