using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module2DemoLibrary;

namespace Module2DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Greeter.GetName();

            MessageBox.Show("Hello " + name);
            Console.WriteLine("Hello " + name);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
