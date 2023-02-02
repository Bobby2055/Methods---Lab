namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            RepeatString(text, n);

            static string RepeatString(string text, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(text);
                }
                return text;
            }
        }
    }
}