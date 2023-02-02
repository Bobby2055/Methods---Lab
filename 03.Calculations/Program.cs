namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (input == "add")
            {
                Console.WriteLine(a + b);
            }
            else if (input == "subtract")
            {
                Console.WriteLine(a - b);
            }
            else if (input == "multiply")
            {
                Console.WriteLine(a * b);
            }
            else if (input == "divide")
            {
                Console.WriteLine(a / b);
            }
        }
    }
}