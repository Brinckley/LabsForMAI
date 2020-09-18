using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class D
    {
        private int num_d;

        public D() { num_d = 0; }
        public void func_D() { num_d++; Console.WriteLine(" Method of D: {0}", num_d); }
    }

    class F
    {
        private int num_f;

        public F() { num_f = 0; }
        public void func_F() { num_f++; Console.WriteLine(" Method of F: {0}", num_f); }
    }

    class J
    {
        private int num_j;

        public J() { num_j = 0; }
        public void func_J() { num_j++; Console.WriteLine(" Method of J: {0}", num_j); }
    }

    class B
    {
        private D obj_d;

        public B() { obj_d = new D(); }
        public void func_B() { Console.WriteLine(" Method of B"); }
        public void func_D() { Console.Write("->D"); obj_d.func_D(); }

        public void general() { func_B(); obj_d.func_D(); }

    }

    class C
    {
        private F obj_f;

        public C() { obj_f = new F(); }
        public void func_C() { Console.WriteLine(" Method of C"); }
        public void func_F() { Console.Write("->F"); obj_f.func_F(); }

        public void general() { func_C(); obj_f.func_F(); }


    }

    class A
    {
        private B obj_b;
        private C obj_c;
        private J obj_j;

        public A()
        {
            obj_b = new B();
            obj_c = new C();
            obj_j = new J();
        }
        public void func_A() { Console.WriteLine(" Method of A"); }
        public void func_B() { Console.Write(" A->B"); obj_b.func_B(); }
        public void func_C() { Console.Write(" A->C"); obj_c.func_C(); }
        public void func_J() { Console.Write(" A->J"); obj_j.func_J(); }
        public void func_D() { Console.Write(" A->B"); obj_b.func_D(); }
        public void func_F() { Console.Write(" A->C"); obj_c.func_F(); }

        public void general() { func_A(); obj_b.general(); obj_c.general(); obj_j.func_J(); }

    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            a.func_A();
            a.func_B();
            a.func_C();
            a.func_J();
            a.func_F();
            a.func_D();
            Console.WriteLine();

            a.func_J();
            a.func_F();
            a.func_D();
            Console.WriteLine();

            a.general();
            Console.ReadKey();
        }
    }
}
