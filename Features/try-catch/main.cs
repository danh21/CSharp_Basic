/******************************************************************************

3 TCs:
- valid: 5 2
- err div by 0: 5 0
- err miss 1 arg: 5

*******************************************************************************/
using System;

class Program
{
    static double Divide(double x, double y)
    {
        if (y == 0)
            throw new DivideByZeroException();
        return x / y;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                throw new InvalidOperationException("First input must be a valid number");
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double y))
            {
                throw new InvalidOperationException("Second input must be a valid number");
            }

            Console.WriteLine("Result: " + Divide(x, y));
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Input Error: " + e.Message);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Math Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}
