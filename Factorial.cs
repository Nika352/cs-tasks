class Factorial { 
    static void Main(string[] args )
    {
        Console.WriteLine("enter integer below this text");
        int n = int.Parse(Console.ReadLine());
        int factorial = findFactorial(n);
        Console.WriteLine("factorial of given number is " + factorial);

    }

    private static int findFactorial(int n) {

        for (int i = n - 1; i > 0; i--) {
            n *= i;
        }

        return n;
    }

}