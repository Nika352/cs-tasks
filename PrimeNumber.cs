class PrimeNumber { 

    static void Main(String[] args)
    {

        Console.WriteLine("enter number below");

        int n = int.Parse(Console.ReadLine());

        int divisors = 0;

        for (int i = 1; i <= n; i++) {
            if (n % i == 0) {
                divisors++;
            }
        }
        if (divisors == 2)
        {
            Console.WriteLine("you entered a prime number");
        }
        else {
            Console.WriteLine("you did not enter a prime number");
        }

    }
}