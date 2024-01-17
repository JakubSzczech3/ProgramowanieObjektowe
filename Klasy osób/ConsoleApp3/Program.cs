using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Jan","Nowak",20);
            Person person2 = new Person("Kamil", "Nowak", 30);
            Person person3 = new Person("Jakub", "Nowak", 21);
            Book book1 = new Book("Marian","Kowalski",15,"Krzyżacy");
            Book book2 = new Book("Henryk","Sienkiewicz",75,"Potop");
            Book book3 = new Book("Jan","Brzechwa",105,"Pan Tadeusz");
            Book[] tablica = { book1, book2, book3 };
            Reader reader1 = new Reader("Dominik", "Czwarty", 55, tablica );

            reader1.ViewBook();



        }
    }
}
