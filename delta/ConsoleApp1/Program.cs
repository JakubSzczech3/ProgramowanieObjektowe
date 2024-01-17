using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rowk();
        }



        static public void Rowk()
        {
            double a = DoubleInput();
            double b = DoubleInput();
            double c = DoubleInput();
            double delta, x1, x2;
            if (a != 0)
            {
                delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("Brak rozwiązania w zbiorze liczb rzeczywistych");
                }
                else if (delta == 0)
                {

                    x1 = -b / (2 * a);
                    Console.WriteLine("x1 = " + x1);
                }
                else {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }

            }
            else {
                Console.WriteLine("To nie jest równanie kwadratowe"); }

        }
        static double DoubleInput() {
            Console.WriteLine("Podaj wartość");
            double value = Convert.ToInt32(Console.ReadLine());
            return value;
        }
     }
}
