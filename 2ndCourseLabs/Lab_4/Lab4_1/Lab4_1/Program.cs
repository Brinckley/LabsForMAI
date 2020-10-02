using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a_obj = new A();
            a_obj.writer();
            C c_obj = new C();
            c_obj.writer();
            c_obj.writer_C();
            Console.WriteLine();

            D_class d_obj = new D_class();
            d_obj.writer();
            Console.WriteLine();

            B_class b_obj = new B_class();
            b_obj.writer();
            F_class f_obj = new F_class();
            f_obj.writer();
            Console.WriteLine();

            J_class j_obj = new J_class();
            j_obj.intro();
            j_obj.printing1();
            j_obj.printing2();
            Console.WriteLine("Text of values: " + j_obj.numberReturner() + " " + j_obj.stringReturner());


            Console.ReadKey();
        }
    }
}
