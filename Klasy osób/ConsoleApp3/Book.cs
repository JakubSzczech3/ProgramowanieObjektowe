using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Book:Person
    {
        private string title;

        public Book(string firstName, string lastName,int age,string title):base(firstName,lastName,age)
        {
            this.title = title;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public string Title { get { return title; } set { } }
        public void View() {
            Console.WriteLine("Imię autora: "+FirstName);
            Console.WriteLine("Nazwisko autora: "+LastName);
            Console.WriteLine("Wiek autora: "+Age);
            Console.WriteLine("Tytuł książki: "+title);
        }

    }
}
