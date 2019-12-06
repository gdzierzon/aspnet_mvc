using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bill";
            int age = 25;
            DateTime birthDate = DateTime.Now.AddYears(-25);
            decimal hourlyRate = 15.25m;

            Console.WriteLine("Name       Age   Birthday   Rate");
            Console.WriteLine("---------- ----- ---------- ----------");

            Console.WriteLine("{0,-10} {1,5} {2,-10:d} {3,-10:C}"
                            , name
                            , age
                            , birthDate
                            , hourlyRate);

            //custome numeric format
            Console.WriteLine("{0,-10} {1,5} {2,-10:d10} {3,-10:$#,###.00;($0.00);intern}"
                            , name
                            , age
                            , birthDate
                            , hourlyRate);

            //custom date format
            Console.WriteLine("{0,-10} {1,5} {2,-10:MMM yyyy} {3,-10:C}"
                            , name
                            , age
                            , birthDate
                            , hourlyRate);

            string message = string.Format("{0,-10} {1,5} {2,-10:d} {3,-10:C}"
                                         , name
                                         , age
                                         , birthDate
                                         , hourlyRate);
            Console.WriteLine(message);

            message = $"{name,-10} {age,5} {birthDate,-10:d} {hourlyRate,-10:C}";
            Console.WriteLine(message);
            /*
             * 1 - template
             * 2 - array of objects:  name (0) - age (1)
             *
             * Formatting Rules/Options
             * { token , width : format precision}
             */

            Console.WriteLine();
            Console.WriteLine();
        }

        static void DoWork()
        {
            int age = 10;
            //value types - stored on the stack and go away immediately
            //int, long, double, float, bool

            //reference types - stored on the heap
            int[] numbers = new[] {1, 2, 3};
            
        }
        
    }
}
