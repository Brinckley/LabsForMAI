using System;

namespace Lab8_1
{

    class OverRide<T> {

        public T tmp { get; set; }

        public OverRide(T tmp) {
            this.tmp = tmp;
        }

        public void print() { Console.WriteLine("Printing value: " + tmp);
            String type = "Value type: ";
            if (tmp is int) {
                type += "int";
            } else if (tmp is string) {
                type += "string";
            } else if (tmp is bool) {
                type += "bool";
            } else { type += "unknown type"; }
            Console.WriteLine(type);
        }

        public static void swap(ref T tmp1, ref T tmp2) {
            T tmp3 = tmp1;
            tmp1 = tmp2;
            tmp2 = tmp3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OverRide<int> value1_int = new OverRide<int>(1);
            OverRide<int> value2_int = new OverRide<int>(2);
            value1_int.print();
            value2_int.print();
            Console.WriteLine();

            OverRide<OverRide<int>>.swap(ref value1_int, ref value2_int);
            value1_int.print();
            value2_int.print();

            Console.ReadKey();
        }
    }
}
