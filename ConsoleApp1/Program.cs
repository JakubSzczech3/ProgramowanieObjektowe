using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            kalk();
        }
        static void view()
        {
            Console.WriteLine("Wybierz operacje");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Roznica");
            Console.WriteLine("3. Iloczyn");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Potega");
            Console.WriteLine("6. Pierwiastek kwadratowy");
            Console.WriteLine("7. Trygonometria");
            Console.WriteLine("8. Wyjscie");
            Console.WriteLine("Twoj wybor");


        }
        static void kalk()
        {
            while (true)
            {
                Console.ReadKey();
                Console.Clear();
                view();

                int operacja = Convert.ToInt32(Console.ReadLine());

                switch (operacja)
                {
                    case 1:
                        Console.Clear();
                        double a = inputDouble();
                        double b = inputDouble();
                        suma(a, b);
                        break;
                    case 2: Console.WriteLine("2"); break;
                    case 3: Console.WriteLine("3"); break;
                    case 4: Console.WriteLine("4"); break;
                    case 5: Console.WriteLine("5"); break;
                    case 6: Console.WriteLine("6"); break;
                    case 7: Console.WriteLine("7"); break;
                    case 8: System.Environment.Exit(0); break;
                    default: Console.WriteLine("domyslnie"); break;
                }
            }
        }
        static void suma(double a, double b) {
            double sum = a + b;
            Console.WriteLine($"Suma {a} + {b} = {sum}");
        
        }
        static double inputDouble() {
            Console.WriteLine("Podaj wartość");
            double a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
    }
}
