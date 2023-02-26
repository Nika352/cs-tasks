namespace Odd_And_Even_Numbers_in_Array
{
    internal class OddAndEvenNumbersInArray
    {
        static void Main(string[] args)
        {
            int[] sampleArray = { 1, 2, 3, 6, 5, 13, 24, 200 };
            int oddNumbers = 0;
            int evenNumbers = 0;

            for (int i = 0; i < sampleArray.Length; i++)
            {
                if (sampleArray[i] % 2 == 0) { 
                    evenNumbers++;
                } else
                {
                    oddNumbers++;
                }
            }

            Console.WriteLine("array has " + oddNumbers + " odd and " + evenNumbers + " even numbers");

        }

    }
}