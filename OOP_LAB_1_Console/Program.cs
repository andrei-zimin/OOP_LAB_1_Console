using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Properties.Settings setings = Properties.Settings.Default;
            Console.WriteLine(Properties.Resources.ResHello + ", " + setings.Name);
            Console.ReadLine();
            Console.WriteLine(Properties.Resources.ResGoodbye + ", " + setings.Name);
            Console.ReadLine();
        }
    }
}
