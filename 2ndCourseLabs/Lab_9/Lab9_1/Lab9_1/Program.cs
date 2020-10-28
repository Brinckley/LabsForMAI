using System;

namespace Lab9_1
{ 

    static class Function {

        public static void nameWriter(string str) { Console.WriteLine("Name: " + str); }
        public static void surnameWriter(string str) { Console.WriteLine("Surname: " + str); }

        public static string nameReturner() { return "Name: " + "CCCC"; }
        public static string surnameReturner() { return "Surname: " + "DDDD"; }

        public static void absoluteSum(int x, int y, Action<int, int> action) { if (x > 0) { action(y, x); } } 
        public static void sum(int x, int y) { Console.WriteLine("Sum: " + (x + y)); }

    }
    class Program
    {
        delegate void Print(string tmp);
        delegate string StringReturner();

        delegate void AnonymousWriter(int tmp);
        delegate long AnonymousReturner(long tmp);

        static void Main(string[] args)
        {
            Print print = Function.nameWriter;
            print("AAAA");
            print = new Print(Function.surnameWriter);
            print("BBBB");
            Console.WriteLine();

            StringReturner stringReturner = Function.nameReturner;
            Console.WriteLine(stringReturner());
            stringReturner = new StringReturner(Function.surnameReturner);
            Console.WriteLine(stringReturner());
            Console.WriteLine();
            
            Print multiPrint = Function.nameWriter;
            multiPrint += Function.surnameWriter;
            multiPrint("No data!");
            Console.WriteLine();

            AnonymousWriter anonymWriter = delegate (int tmp) {
                Console.WriteLine("In anonymous delegate");
                Console.WriteLine("Value of anonymWriter: " + tmp);
            };
            anonymWriter(7);
            Console.WriteLine();

            AnonymousReturner anonymReturner = delegate (long tmp) {
                Console.WriteLine("In anonymous delegate");
                return tmp / 10;
            };
            Console.WriteLine("Value of anonymReturner: " + anonymReturner(10000001));
            Console.WriteLine();

            Func<int, int, string> sum = delegate (int tmp1, int tmp2) {
                return "Result: " + (tmp1 + tmp2);
            };
            Console.WriteLine(sum(66, 4));
            Console.WriteLine();

            Action<int, int> action = Function.sum;
            Function.absoluteSum(1, 2, action);

            Console.ReadKey();
        }
    }
}
