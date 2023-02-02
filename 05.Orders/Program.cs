namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            if (input == "coffee")
            {
                double all = num * 1.50;
                Console.WriteLine($"{all:F2}");
            }
            else if(input == "water")
            {
                double all = num * 1.00;
                Console.WriteLine($"{all:F2}");
            }
            else if(input == "coke")
            {
                double all = num * 1.40;
                Console.WriteLine($"{all:F2}");
            }
            else if(input == "snacks")
            {
                double all = num * 2.00;
                Console.WriteLine($"{all:F2}");
            }
        }
    }
}