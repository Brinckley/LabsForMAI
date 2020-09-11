using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TestClass constructors are working...");
            TestClass testClass = new TestClass();
            testClass = new TestClass(1);
            testClass = new TestClass(1, 2);
            Console.WriteLine("\nOverriding methods from TestClass...");
            testClass.F();
            testClass.F(5);
            testClass.F(6, "Function is working...");

            Console.WriteLine("\nOverriding methods from Program...");
            F();
            int answer1 = F(testClass);
            F(testClass, "Function is working...");

            Console.WriteLine("The end...");

            Console.ReadKey();
        }

        public static void F()
        {
            Console.WriteLine("ProgramClass F0 ");
        }

        public static int F(TestClass testClass)
        {
            Console.WriteLine("TestClass F1 " + testClass.a);
            return testClass.a;
        }

        public static void F(TestClass testClass, string f)
        {
            Console.WriteLine("TestClass F2 " + testClass.a + " / " + f);
        }

    }
}
