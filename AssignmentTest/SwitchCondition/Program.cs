using System;
namespace SwitchCondition;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter 1 num: ");
        double number1=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2 num: ");
        double number2=double.Parse(Console.ReadLine());
        
        char options=char.Parse(Console.ReadLine());
        switch (options)
        {
            case '+' :
            {
                Console.WriteLine(number1+number2);
                break;
            }
            case'-' :
            {
                Console.WriteLine(number1-number2);
                break;
            }
            case'*' :
            {
                Console.WriteLine(number1*number2);
                break;
            }
            case'/' :
            {
                Console.WriteLine(number1/number2);
                break;
            }
            case'%' :
            {
                Console.WriteLine(number1%number2);
                break;
            }
            default:
            {
                Console.WriteLine("invalid");
                break;
            }
        }

    }
}