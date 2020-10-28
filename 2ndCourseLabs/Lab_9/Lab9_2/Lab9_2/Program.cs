using System;
using System.Collections.Generic;

namespace Lab9_2
{
    class Program
    {
        public static bool lambda(int x, int y) => x > y; 
        
        delegate bool PositiveCheck(int tmp1, int tmp2);

        static void Main(string[] args) {
            PositiveCheck positiveCheck = (x, y) => (x + y) > 0;
            Console.WriteLine("Result of the check: " + positiveCheck(-77, 88));
            Console.WriteLine();

            Console.WriteLine("Just Lambda function result (for 2 and 9): " + lambda(2, 9));
            Console.WriteLine();

            List<int> list = new List<int>() { 0, -8, -9, 98, 55 };
            Console.WriteLine("First positive number in list: " + list[list.FindIndex(x => x > 0)]);
            Console.ReadKey();
        }
        
        
    }
}
