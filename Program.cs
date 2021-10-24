namespace JasVersion
{
    class Program
    {
        static double Convertcf(double c)
        {
            return (c * (9.0 / 5.0)) + 32.0;
        }

        static double Convertfc(double f)
        {
            return (f-32.0) * (5.0 / 9.0);
        }

        static double Average(int value1, int value2, int value3, int value4, int value5)
        {
            return (value1 + value2 + value3 + value4 + value5) / 5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Convertcf(1).ToString("F2") + " F");
            Console.WriteLine(Convertfc(1).ToString("F2") + " C");
            Console.WriteLine(Average(1, 2, 3, 4, 5));
        }
    }
}