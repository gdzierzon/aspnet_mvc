using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Program
    {
        private static string name;
        private static int age;

        public static void DisplayData()
        {
            Console.WriteLine("{0} is {1}", name, age);
        }

        public static string GetDescription()
        {
            string description = "";
            if (age < 18)
            {
                description = "Minor";
            }
            else
            {
                description = "Adult";
            }
            return description;
        }

        public static void Main(string[] args) //starting point
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Write("Enter a name: ");
            name = Console.ReadLine();

            Console.Write("Enter the age: ");
            string ageInput = Console.ReadLine(); //twenty four
            age = Convert.ToInt32(ageInput);
            age = int.Parse(ageInput);

            bool isNumber = int.TryParse(ageInput, out age);

            string theAge = age.ToString();

            int a = 5;
            double b = 5.5;
            decimal c = 5.25m;
            float d = 5.5f;
            char e = 'a';
            string f = "string";

            int x;
            double y, z;
            x = 5;
            y = 3;

            y = y + 1;
            y += 1;
            Console.WriteLine(y++);
            Console.WriteLine(++y);

            z = x / y; // 1 R 2

            // x ^ y

            DisplayData();
            string description = GetDescription();
            Console.WriteLine("{0} is a/an {1}", name, description);
        }

    }
}
