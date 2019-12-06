using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Asset;
using static System.Math;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //   string name;
            //   name = "Gregor";

            //   int age;
            //   age = 19;

            //   Person ezra, ian; //ezra and ian are on the stack

            //   the actual object(i.e.name and age) are stored on the heap
            //ezra = new Person("Ezra", 20);
            //   ian = new Person("Ian", 19);

            //   ezra.Display();
            //   ezra.HaveABirthday();
            //   ezra.Display();

            //   Console.WriteLine(ezra.Name);
            //   ezra.Name = "Johnny";
            //   Console.WriteLine(ezra.Name);
            //   ezra.Name = "   ";
            //   Console.WriteLine(ezra.Name);


            //   Console.ReadKey();

            //   Person sid = new Person("Siddalee", 18);
            //   Person eli = new Person("Elisha", 17);
            //   Person pursy = new Person("Pursalane", 15);
            //   Person zeph = new Person("Zephaniah", 13);

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age: ");
            //string ageInput = Console.ReadLine();
            //int age = int.Parse(ageInput);

            Person person = new Person();
            //Person person2 = new Person(name, age);

            person.ToString();
            

            //person.Display();
            //person2.Display();
            //Console.WriteLine(Person.Count);

            Console.WriteLine();
            Console.WriteLine(PI);
            
            Bond bond = new Bond();

        }

    }

    namespace Asset
    {
        public class Stock
        {

        }

        public class Bond
        {

        }
    }

    namespace Asset.Intangible
    {
        public class Health
        {

        }
    }
}
