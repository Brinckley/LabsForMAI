using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            F f_obj = new F();
            Console.WriteLine("Number from F object: " + f_obj.getterNum());
            Console.WriteLine();

            f_obj = new D();
            Console.WriteLine("Number from D object: " + f_obj.getterNum());
            Console.WriteLine();

            f_obj = new G(45, 54);
            Console.WriteLine("Number from G object: " + f_obj.getterNum());
            Console.WriteLine();
            
            Console.WriteLine("Field from superclass in the end: " + f_obj.f);


            Console.ReadKey();
        }
    }
}
