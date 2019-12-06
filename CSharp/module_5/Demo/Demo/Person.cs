using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public static int Count { get; set; }

        public Person()
            : this("Undefined", 0)
        {
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Count++;
        }

        public void HaveABirthday()
        {
            Age++;
        }

        public void Display()
        {
            Console.WriteLine($"{Name} is {Age}");
        }
    }
}
