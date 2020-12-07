using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        private string name;
        private string surname;
        private int age;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
       {
            this.name = name;
            this.surname = surname;
            this.age = age;    
       }

        public override string ToString()
        {
            return $"name:{this.name} \nsurname:{this.surname} \nage:{this.age} ";
        }
    }   
}
