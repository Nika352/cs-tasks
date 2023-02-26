class QuadraticEquation {

    static void Main(String[] args)
    {
        Console.WriteLine("enter 3 numbers below");

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double D = (b * b - 4 * a * c);
        if (a == 0) { 
            Console.WriteLine("a can't be equal to 0 because this equation must be quadratic");
        } else if (D < 0)
        {
            Console.WriteLine("zero roots");
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("x equals " + x);
        }
        else { 
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x1 equals " + x1 + " and x2 equals " + x2);
        }

    }

}