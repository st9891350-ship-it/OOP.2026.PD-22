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

            triangle Ttst = new triangle(a, b, c);
            Ttst.CheckTriangle();
        }
    }

}
