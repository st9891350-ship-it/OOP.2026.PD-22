namespace Task_program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть сторону а:");
            double a = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Введiть сторону b:");
            double b = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Введiть сторону c:");
            double c = double.Parse(Console.ReadLine()!);

            if (a + b > c && a + c > b && b + c > a)
            {
                double p = (a + b + c) / 2;
                Console.WriteLine($"Пів периметр: {p}");
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Площа трикутника за формулой Герона: {s}");
                double P = a + b + c;
                Console.WriteLine($"Периметр трикутника: {P}");
            }


            if (a == b && b == c)
             { 
              Console.WriteLine("Трикутник рівносторонній.");
            }

             (a == b || b == c || a == c)
            {
                Console.WriteLine("Трикутник рівнобедрений.");
            }
            else (a ^ 2 + b ^ 2 == c ^ 2)
            {
                Console.WriteLine("Трикутник різносторонній.");
            }


            else
            {
                Console.WriteLine("Трикутник не існує.");
            }

        }
    }

}
