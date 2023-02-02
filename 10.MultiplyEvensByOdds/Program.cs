namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = Console.ReadLine();
            int sumOfEven = GetSum(numberAsString, true);
            int sumOfOdd = GetSum(numberAsString, false);
            
            int result = sumOfEven * sumOfOdd;
            Console.WriteLine(result);
        }
        static int GetSum(string numbers, bool isEven)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (char.IsDigit(numbers[i]))
                {
                    int currentNumber = int.Parse(numbers[i].ToString());

                    if (currentNumber % 2 == 0 && isEven)
                    {
                        sum += currentNumber;
                    }
                    else if (currentNumber % 2 != 0 && !isEven)
                    {
                        sum += currentNumber;
                    }
                }
            }
            return sum;
        }
    }
}