using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Functions {

    class Func {

        string str;

        public Func() {
            str = "Hi!";
        }

        public Func(string str) {
            this.str = str;
        }

        public static void writer(Func func) {
            Console.WriteLine("In void function!");
            Console.WriteLine("String from the object: " + func.str);
        }

        public string strGetter() {
            Console.WriteLine("In string function!");
            return str;
        }
    }

}

namespace Lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions.Func func1 = new Functions.Func();
            Functions.Func func2 = new Functions.Func("Hello!");
            Functions.Func func3 = new Functions.Func("Good morning!");

            Functions.Func.writer(func1);
            Console.WriteLine();
            Functions.Func.writer(func2);
            Console.WriteLine();
            Functions.Func.writer(func3);
            Console.WriteLine();
            Console.WriteLine("String value from the first object: " + func1.strGetter());
            Console.ReadKey();
        }
    }
}
