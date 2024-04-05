using System;
using System.Xml.Serialization;
namespace MethodsCondition;
class Program
{
    public static void Main(string[] args)
    {
       string option;
       do
       {
          Console.WriteLine("Enter the numbers: ");
          double num1=double.Parse(Console.ReadLine());
          double num2=double.Parse(Console.ReadLine());

          Console.WriteLine("choose option");
          Console.WriteLine("1.Addition");
          Console.WriteLine("2,substraction");
          Console.WriteLine("3.Multiplication");
          Console.WriteLine("4.division");
          Console.Write("Enter your choice(1/2/3/4):");
          int choice=int.Parse(Console.ReadLine());
        
          switch(choice)
          {
                case 1:
                  Console.WriteLine($"Result: {add(num1,num2)}");
                  break;
                case 2:
                   Console.WriteLine($"Result: {sub(num1,num2)}");
                   break;
                case 3:
                   Console.WriteLine($"Result: {mul(num1,num2)}");
                   break;
                case 4:
                   Console.WriteLine($"Result : {div(num1,num2)}");
                   break;
                default:
                   Console.WriteLine("invalid");
                   break;
         }
        Console.WriteLine("DO you want to continue(yes/no): ");
        option=Console.ReadLine();
       }
        while(option.ToLower()=="yes");
    }
        static double add(double x,double y)
        {
        return x+y;
        }
 
        static double sub(double x,double y)
        {
        return x-y;
        }
        static double mul(double x,double y)
        {
        return x*y;
        }

        static double div(double x,double y)
        {
            if(y!=0)
              return x/y;
            else
            {
                Console.WriteLine("cannot divided byy zero!");
                return double.NaN;
            }
     
        }
    

}


