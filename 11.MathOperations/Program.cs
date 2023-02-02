namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());

            if (operation == "+")
            {
                Console.WriteLine(a + b);
            }
            else if (operation == "-")
            {
                Console.WriteLine(a - b);
            }
            else if (operation == "*")
            {
                Console.WriteLine(a * b);
            }
            else if (operation == "/")
            {
                Console.WriteLine(a / b);
            }
        }
    }
}