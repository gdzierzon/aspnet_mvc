using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2DemoLibrary
{
    public class Greeter
    {
        public static string GetName()
        {
            Console.Write("Please enter your name: ");
            string input = Console.ReadLine();

            return input;
        }
    }
}
