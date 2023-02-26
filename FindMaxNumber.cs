using System.Security.Claims;

namespace Find_Max_Number
{
    internal class FindMaxNumber    
    {
        static void Main(string[] args)
        {

            int[] sampleArray = { 1, 2, 3, -1, -3, 9, 0};
            Console.WriteLine("max number in this array is: " + findMaxNumber(sampleArray));

        }

        private static int findMaxNumber(int[] numbers) {
            int max = int.MinValue;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}