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

        public B b { get { return objb; } }
        public C c { get { return objc; } }
        public J j { get { return objj; } }

        public A(B objb, C objc, J objj)
        {
            this.objb = objb;
            this.objc = objc;
            this.objj = objj;
        }

        public A() {
            objb = new B();

        }

        public void hashPrint() { Console.WriteLine("A object hash: " + this.GetHashCode()); }

    }

    class B
    {
        D objd;

        public B(D objd) { this.objd = objd; }
        public B() {}

        public D d { get { return objd; } }

        public void hashPrint() { Console.WriteLine("B object hash: " + this.GetHashCode()); }
    }

    class C
    {
        F objf;

        public C(F objf) { this.objf = objf; }
        public C() { }

        public F f { get { return objf; } }

        public void hashPrint() { Console.WriteLine("C object hash: " + this.GetHashCode()); }
    }

    class D
    {
        int number = 4;
        public D() {}

        public D(int number) { this.number = number; }

        public void hashPrint() { Console.WriteLine("D object hash: " + this.GetHashCode()); }
    }

    class J
    {
        int number = 5;

        public J() {}
        public J(int number) { this.number = number; }

        public void hashPrint() { Console.WriteLine("J object hash: " + this.GetHashCode()); }
    }

    class F
    {
        int number = 6;

        public F() { }
        public F(int number) { this.number = number; }

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
            

            
            b.hashPrint();
            a.b.hashPrint();

            Console.WriteLine();
            c.hashPrint();
            a.c.hashPrint();

            Console.WriteLine();
            j.hashPrint();
            a.j.hashPrint();
            
            Console.WriteLine();
            d.hashPrint();
            b.d.hashPrint();

            Console.WriteLine();
            f.hashPrint();
            c.f.hashPrint();
            Console.WriteLine();


            Console.ReadKey();
            
        }
    }
}
