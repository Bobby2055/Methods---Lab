namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int greatedValue = GetMax(a, b);
                Console.WriteLine(greatedValue);
            }
            else if (type == "double")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double greatedValue = GetMax(a, b);
                Console.WriteLine(greatedValue);
            }
            else if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string greatedValue = GetMax(a, b);
                Console.WriteLine(greatedValue);
            }
            else if(type == "char") 
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char greatedValue = GetMax(a, b);
                Console.WriteLine(greatedValue);
            } 
        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static double GetMax(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static string GetMax(string a, string b)
        {
            int result = a.CompareTo(b);

            if (result > 0)
            {
                return a;
            }
            return b; 
        }
    }
}