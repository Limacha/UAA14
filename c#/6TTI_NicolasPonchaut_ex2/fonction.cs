using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_NicolasPonchaut_ex2
{
    public struct func
    {
        public void LireDouble(int i, out double x)
        {
            string n = "";
            do
            {
                Console.WriteLine("double a lire" + i);
                n = Console.ReadLine();
            } while (!double.TryParse(n, out x));
        }

        public void colorConsole(ConsoleColor bg, ConsoleColor text)
        {
            Console.BackgroundColor = bg;
            Console.ForegroundColor = text;

        }
    }
}
