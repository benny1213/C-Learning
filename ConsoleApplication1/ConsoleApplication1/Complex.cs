using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Complex
    {
        private float rp;
        private float ip;
        public Complex(float rp, float ip)
        {
            this.rp = rp;
            this.ip = ip;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex(0, 0);
            c.rp = c1.rp + c2.rp;
            c.ip = c1.ip + c2.ip;
            return c;
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1.rp - c2.rp, c1.ip - c2.ip);
            return c;
        }
        public static Complex operator -(Complex c)
        {
            Complex cc = new Complex(-c.rp, -c.ip);
            return cc;
        }
        public void show()
        {
            if (ip >= 0) Console.WriteLine("{0} + {1}i", rp, ip);
            else Console.WriteLine("{0} - {1}i", rp, -ip);
        }
    }
}
