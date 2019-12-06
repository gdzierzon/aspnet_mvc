using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        /// <summary>
        /// This method takes 2 numbers and subtracts the 2nd from the 1st.
        /// </summary>
        /// <param name="x">This is an integer</param>
        /// <param name="y">Y is supbtracted from x.</param>
        /// <returns></returns>
        public static int Subtract(int x, int y)
        {
            int difference = x - y;
            return difference;
        }

        public static void Display(int x, int y,
                                   string operation,
                                   int result)
        {
            Console.WriteLine("{0} {1} {2} = {3}", x,
                              operation, y, result);
        }
        
        static void Main(string[] args) //the starting point
        {
            int a = 7, b = 2, c;
            
            //perform addition
            c = Add(a, b);
            Display(a, b, "+", c);

            //perform subtraction
            c = Subtract(a, b);
            Display(a, b, "-", c);
        }

    }
}
