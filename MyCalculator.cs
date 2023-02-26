public class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("please enter 2 numbers below");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("enter operation you want to be performed (sum, sub, divide, multiply)");
        String operation = Console.ReadLine();

        if (operation.Equals("sum"))
        {
            Console.WriteLine(sum(a, b));
        }
        else if (operation.Equals("sub"))
        {
            Console.WriteLine(sub(a, b));
        }
        else if (operation.Equals("divide"))
        {
            Console.WriteLine(divide(a, b));
        }
        else if (operation.Equals("multiply"))
        {
            Console.WriteLine(multiply(a, b));
        }

    }

    private static double sum(double a, double b)
    {
        return a + b;
    }
    private static double sub(double a, double b)
    {
        return a - b;
    }
    private static double divide(double a, double b)
    {
        return a / b;
    }
    private static double multiply(double a, double b)
    {
        return a * b;
    }

}