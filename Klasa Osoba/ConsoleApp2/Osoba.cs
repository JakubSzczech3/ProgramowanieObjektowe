using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Osoba
    {
        private string name;
        private int age;

        public string Name {
            get { return name;  }
            set { }
        }
        public int Age { get { return age; } set {  } }
        public Osoba(string name, int age) {
            this.name = name;
            this.age = age;
        
        }

    }
}
