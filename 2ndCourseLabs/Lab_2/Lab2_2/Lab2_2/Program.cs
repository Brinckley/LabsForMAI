using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A.B b = new A.B();
            A.C c = new A.C();

            a.general();
            Console.WriteLine();

            b.general();
            Console.WriteLine();

            c.general();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
