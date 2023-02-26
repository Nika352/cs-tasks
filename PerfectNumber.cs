class PerfectNumber { 

    static void Main(String[] args)
    {
        Console.WriteLine("enter number below");

        int n = int.Parse(Console.ReadLine());

        int divisorsSum = 0;

        for (int i = 1; i < n; i++) {
            if (n % i == 0) {
                divisorsSum += i;
            }
        }

        if (divisorsSum == n) {
            Console.WriteLine("entered number is perfect");
        } else {
            Console.WriteLine("entered number isn't perfect");
        }
    }

}