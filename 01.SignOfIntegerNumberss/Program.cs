namespace _01.SignOfIntegerNumberss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumberSign(int.Parse(Console.ReadLine()!));
        }

        static void PrintNumberSign(int n) 
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if(n < 0)
            {
                Console.WriteLine($"The number {n} is negative. ");
            }
            else if(n == 0)
            {
                Console.WriteLine($"The number {n} is zero. ");
            }
        }
    }
}