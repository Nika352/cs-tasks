class TriangleSides
{

    static void Main(string[] args) {

        Console.WriteLine("add 3 doubles");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Boolean satisfiesTriangleRule = false;

        if (a + b > c && b + c > a && a + c > b) { 
            satisfiesTriangleRule = true;
        }

        if (satisfiesTriangleRule)
        {
            Console.WriteLine("entered numbers could be triangle side lengths");
        }
        else {
            Console.WriteLine("entered numbers could not be triangle side lengths");
        }



    }

}