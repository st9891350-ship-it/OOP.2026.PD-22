using System;
using System.Collections.Generic;
using System.Text;

namespace Task_program_1
{
    public class triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void CheckTriangle()
        {
            if (A + B > C && A + C > B && B + C > A)
            {
                double P = A + B + C;
                double p = P / 2;
                double s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

                Console.WriteLine($"Периметр трикутника: {P}");
                Console.WriteLine($"Пів периметр: {p}");
                Console.WriteLine($"Площа трикутника за формулой Герона: {s}");

            }


            else if (A == B && B == C)
            {
                Console.WriteLine("Трикутник рівносторонній.");
            }
            else if (A == B || B == C || A == C)
            {
                Console.WriteLine("Трикутник рівнобедрений.");
            }
            else if (A * A + B * B == C * C || A * A + C * C == B * B || B * B + C * C == A * A     )
            {
                Console.WriteLine("Трикутник прямокутний.");
            }
            else
            {
                Console.WriteLine("Трикутник не існує.");
            }

        }

    }
}
