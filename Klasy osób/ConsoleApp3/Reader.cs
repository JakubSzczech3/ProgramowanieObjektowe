using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Reader:Person
    {
        Book[] Books;
public Reader(string firstName,string lastName, int age, Book[] book): base(firstName,lastName,age)
        {
            this.Books = book;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public void ViewBook() {
            Console.WriteLine("Imię: "+FirstName);
            Console.WriteLine("Nazwisko: "+LastName);
            Console.WriteLine("Tytuły:");
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine(Books[i].Title);
            }
        
        }
    }
}
