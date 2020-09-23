using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class F
    {
        protected int number = 5;

        public F() {
            Console.WriteLine("Constructor of F class");
            number = 0;
        }

        public F(int number) {
            this.number = number;
        }

        public int f { get { return number; } }

        public virtual int getterNum() {
            return number;
        }

    }

    class D : F
    {
        public D() {
            Console.WriteLine("Constructor of F class");
            number++;
        }

        public D(int arg) {
            number = arg;
        }

        public override int getterNum() {
            return 2 * number;
        }
    }

    class G : D
    {
        private int number_G;

        public G(int arg1, int arg2) : base(arg1)
        {
            number_G = arg2;
        }

        public G() {
            Console.WriteLine("Constructor of F class");
            number++;
        }

        public override int getterNum()
        {
            return 3 * number;
        }
    }
}
