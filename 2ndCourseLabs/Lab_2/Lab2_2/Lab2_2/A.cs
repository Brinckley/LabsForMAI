using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class A
    {
        public class B
        {
            private D obj_d;

            public B() { obj_d = new D(); }
            public void func_B() { Console.WriteLine(" Method of B"); }

            public void general() { func_B(); obj_d.func_D(); }

            public class D
            {
                private int num_d;

                public D() { num_d = 0; }
                public void func_D() { num_d++; Console.WriteLine(" Method of D: {0}", num_d); }
            }


        }

        public class C
        {
            private F obj_f;

            public C() { obj_f = new F(); }
            public void func_C() { Console.WriteLine(" Method of C"); }

            public void general() { func_C(); obj_f.func_F(); }

            public class F
            {
                private int num_f;

                public F() { num_f = 0; }
                public void func_F() { num_f++; Console.WriteLine(" Method of F: {0}", num_f); }
            }


        }

        public class J
        {
            private int num_j;

            public J() { num_j = 0; }
            public void func_J() { Console.WriteLine(" Method of J"); }
        }

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

        public void general() { func_A(); obj_b.general(); obj_c.general(); obj_j.func_J(); }

    }
}
