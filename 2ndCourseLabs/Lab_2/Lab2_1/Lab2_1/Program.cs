using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class A
    {
        B objb = null;
        C objc = null;
        J objj = null;

        public B b { get { return objb; } }
        public C c { get { return objc; } }
        public J j { get { return objj; } }

        public A() {
            objb = new B();
            objc = new C();
            objj = new J();
        }

        public A(B objb, C objc, J objj)
        {
            this.objb = objb;
            this.objc = objc;
            this.objj = objj;
        }

        public void print_A() { Console.WriteLine("   Method of A"); }

        public void hashPrint() { Console.WriteLine("A object hash: " + this.GetHashCode()); }

    }

    class B
    {
        D objd = null;

        public B(D objd) { this.objd = objd; }
        public B() { objd = new D(); }

        public D d { get { return objd; } }

        public void print_B() { Console.WriteLine("   Method of B"); }

        public void hashPrint() { Console.WriteLine("B object hash: " + this.GetHashCode()); }
    }

    class C
    {
        F objf = null;

        public C(F objf) { this.objf = objf; }
        public C() { objf = new F(); }

        public F f { get { return objf; } }

        public void print_C() { Console.WriteLine("   Method of C"); }

        public void hashPrint() { Console.WriteLine("C object hash: " + this.GetHashCode()); }
    }

    class D
    {
        int number = 4;

        public int d { get { return number; }  }

        public D() {}

        public D(int number) { this.number = number; }

        public void print_D() { Console.WriteLine("   Method of D, value: " + d); }

        public void hashPrint() { Console.WriteLine("D object hash: " + this.GetHashCode()); }
    }

    class J
    {
        int number = 5;

        public int j { get { return number; } }

        public J() {}
        public J(int number) { this.number = number; }

        public void print_J() { Console.WriteLine("   Method of J, value: " + j); }

        public void hashPrint() { Console.WriteLine("J object hash: " + this.GetHashCode()); }
    }

    class F
    {
        int number = 6;

        public int f { get { return number; } }

        public F() { }
        public F(int number) { this.number = number; }

        public void print_F() { Console.WriteLine("   Method of F, value: " + f); }

        public void hashPrint() { Console.WriteLine("F object hash: " + this.GetHashCode()); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj_a = new A();
            obj_a.print_A();
            Console.WriteLine();

            J obj_j = obj_a.j;
            obj_j.print_J();
            Console.WriteLine();

            C obj_c = obj_a.c;
            obj_c.print_C();
            F obj_f = obj_c.f;
            obj_f.print_F();
            Console.WriteLine();

            B obj_b = obj_a.b;
            obj_b.print_B();
            D obj_d = obj_b.d;
            obj_d.print_D();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
