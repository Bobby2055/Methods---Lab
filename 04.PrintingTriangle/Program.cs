namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                test(i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                test(i);
            }
        }

        static void test(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}