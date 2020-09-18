using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{

    class A
    {
        B objb;
        C objc;
        J objj;

        public B b { get { Console.Write("a->b"); return objb; } }
        public C c { get { Console.Write("a->c"); return objc; } }
        public J j { get { Console.Write("a->j"); return objj; } }

        public A(B objb, C objc, J objj)
        {
            this.objb = objb;
            this.objc = objc;
            this.objj = objj;
        }

        public void general_A() { Console.Write("   Method of A\n"); }

        public void hashPrint() { Console.WriteLine("A object hash: " + this.GetHashCode()); }

    }

    class B
    {
        D objd;

        public B(D objd) { this.objd = objd; }
        public B() {}

        public D d { get { Console.Write("->d"); return objd; } }

        public void general_B() { Console.Write("   Method of B\n"); }

        public void hashPrint() { Console.WriteLine("B object hash: " + this.GetHashCode()); }
    }

    class C
    {
        F objf;

        public C(F objf) { this.objf = objf; }
        public C() { }

        public F f { get { Console.Write("->f"); return objf; } }

        public void general_C() { Console.Write("   Method of C\n"); }

        public void hashPrint() { Console.WriteLine("C object hash: " + this.GetHashCode()); }
    }

    class D
    {
        int number = 4;
        public D() {}

        public D(int number) { this.number = number; }

        public void general_D() { Console.Write("   Method of D\n"); }

        public void hashPrint() { Console.WriteLine("D object hash: " + this.GetHashCode()); }
    }

    class J
    {
        int number = 5;

        public J() {}
        public J(int number) { this.number = number; }

        public void general_J() { Console.Write("   Method of J\n"); }

        public void hashPrint() { Console.WriteLine("J object hash: " + this.GetHashCode()); }
    }

    class F
    {
        int number = 6;

        public F() { }
        public F(int number) { this.number = number; }

        public void general_F() { Console.WriteLine("   Method of F\n"); }

        public void hashPrint() { Console.WriteLine("F object hash: " + this.GetHashCode()); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            J j = new J(0);
            F f = new F(1);
            D d = new D(2);

            B b = new B(d);
            C c = new C(f);
            A a = new A(b, c, j);

            a.general_A();
            Console.WriteLine();

            a.b.general_B();
            Console.WriteLine();
            a.c.general_C();
            Console.WriteLine();
            a.j.general_J();
            Console.WriteLine();

            a.b.d.general_D();
            Console.WriteLine();
            a.c.f.general_F();
            Console.WriteLine();


            Console.ReadKey();
            
        }
    }
}
