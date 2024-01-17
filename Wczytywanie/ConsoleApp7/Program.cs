using System;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer albumu: ");
            string numerAlbumu = Console.ReadLine();
            Console.WriteLine("Podaj nazwę pliku: ");
            string nazwaPliku = Console.ReadLine();

            using (var sw = new StreamWriter(nazwaPliku, append: true))
            {

                sw.WriteLine(numerAlbumu);
            }
            using (var sr = new StreamReader(nazwaPliku))
            {
                var line = sr.ReadToEnd();
                Console.WriteLine(line);
            }

            


        }
    }
}
