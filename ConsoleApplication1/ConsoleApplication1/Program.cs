using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(2, 3);
            Console.Write("c1= "); c1.show();
            Console.Write("c2= "); c2.show();
            Complex c = c1 + c2;
            Console.Write("c1 + c2= "); c.show();
            Complex d = c1 - c2;
            Console.Write("c1 - c2= "); d.show();
            Console.ReadLine();
        }
    }
}
