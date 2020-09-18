using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class TestClass
    {
        public int a;
        private int b;

        public TestClass() {
            Console.WriteLine("Default constructor");
            a = 0;
            b = 0;
        }

        public TestClass(int tmp)
        {
            Console.WriteLine("Constructor number 1");
            a = tmp;
            b = tmp;
        }

        public TestClass(int tmp1, int tmp2)
        {
            Console.WriteLine("Constructor number 2");
            a = tmp1;
            b = tmp2;
        }

        public void F() {
            Console.WriteLine("TestClass F0 " + a + " " + b);
        }

        public int F(int tmp)
        {
            Console.WriteLine("TestClass F1 " + a + " " + b);
            return a + b + tmp;
        }

        public void F(int tmp, string f)
        {
            a += tmp;
            b += tmp;
            Console.WriteLine("TestClass F2 " + a + " " + b + " / " + f);
        }
    }
}
