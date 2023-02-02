namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double raisedNumber = RaisedNumber(value, power);

            Console.WriteLine(raisedNumber);
        }
        public static double RaisedNumber(double value, int power)
        {
            double newNumber = 1;
            for (int i = 1; i <= power; i++)
            {
                newNumber = newNumber * value;
            }
            return newNumber;
        }
    }
}