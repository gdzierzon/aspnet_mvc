using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void IfStatements()
        {
            int age = 23;
            decimal price = 12.75m;

            if (age >= 65)
            {
                price = 9.95m;
                Console.WriteLine("discount applied.");
            }



            if (age < 65)
            {
                price = 12.75m;
            }
            else
            {
                price = 9.95m;
            }

            price = age < 65 //test
                        ? 12.75m // value if true
                        : 9.95m; // value if false



            if (age < 3)
            {
                price = 0;
            }
            else if (age < 10)
            {
                price = 6.95m;
            }
            else if (age < 18)
            {
                price = 12.95m;
            }
            else if (age < 65)
            {
                price = 19.95m;
            }
            else
            {
                price = 14.95m;
            }
            

        }

        public static void SwitchStatements()
        {
            string state = "Wyoming"; //get value from user

            switch (state)
            {
                case "Alaska":
                case "Alabama":
                    //do something
                    Console.WriteLine("first");
                    break;
                case "Tennessee":
                    //do something else
                    break;
                default:
                    //catch all
                    break;
            }

            switch (state)
            {
                case "Alaska":
                case "Florida":
                case "Nevada":
                case "South Dakota":
                case "Texas":
                case "Washington":
                case "Wyoming":
                    Console.WriteLine("has no personal income tax");
                    break;
                case "New Hampshire":
                case "Tennessee":
                    Console.WriteLine(
                                      "taxes dividend and interest income only");
                    break;
                default:
                    Console.WriteLine("has a personal income tax");
                    break;
            }

        }

        public static void WhileLoop()
        {
            //great for when we don't know how many times we will need to loop
            StreamReader reader = new StreamReader("C:\\files\\names.txt");
            while (!reader.EndOfStream)
            {
                string name = reader.ReadLine();
                Console.WriteLine(name);
            }
        }

        public static void DoWhileLoop()
        {
            //same as while, but guarantees it will execute at least once
            string goAgain;

            do
            {
                Console.WriteLine("Welcome...");
                Console.WriteLine();

                //...

                Console.Write("Do you want to try again? ");
                goAgain = Console.ReadLine().ToLower();

            } while (goAgain == "y");

        }

        public static void ForLoops()
        {
            List<string> names = new List<string>{"Gregor"
                                                   , "Amy"
                                                   , "Autumn"
                                                   , "Breanna"
                                                   , "Cody"
                                                   , "Decker"
                                                 };

            for (int i = 0; i < names.Count; i++)
            {
                string name = names[i];
                Console.WriteLine(name);
            }


            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        
    }
}
