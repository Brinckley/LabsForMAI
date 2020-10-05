using System;

namespace Lab6_1
{

    class A {
        public A() { }
        public A(B b, C c, J j) { this.b = b; this.c = c; this.j = j; }

        public void aHashCode() { Console.WriteLine("A class hash:   " + this.GetHashCode()); }

        B bField;
        public B b { get { return bField; } set { if (value != null) { bField = value; } } }

        C cField;
        public C c { get { return cField; } set { if (value != null) { cField = value; } } }

        J jField;
        public J j { get { return jField; } set { if (value != null) { jField = value; } } }
    }

    class B {
        public B() { }
        public B(D d) { this.d = d; }

        public void bHashCode() { Console.WriteLine("B class hash:   " + this.GetHashCode()); }

        D dField;
        public D d { get { return dField; } set { if (value != null) { dField = value; } } }
    }

    class C
    {
        public C() { }
        public C(F f) { this.f = f; }

        public void cHashCode() { Console.WriteLine("C class hash:   " + this.GetHashCode()); }

        F fField;
        public F f { get { return fField; } set { if (value != null) { fField = value; } } }
    }

    class J
    {
        public J() { }
        public J(A a) { this.a = a; }

        public void jHashCode() { Console.WriteLine("J class hash:   " + this.GetHashCode()); }

        A aField;
        public A a { get { return aField; } set { if (value != null) { aField = value; } } }
    }

    class D {
        public D() { }
        public D(A a) { this.a = a; }

        public void dHashCode() { Console.WriteLine("D class hash:   " + this.GetHashCode()); }

        A aField;
        public A a { get { return aField; } set { if (value != null) { aField = value; } } }
    }

    class F {
        public F() { }
        public F(A a) { this.a = a; }

        public void fHashCode() { Console.WriteLine("F class hash:   " + this.GetHashCode()); }

        A aField;
        public A a { get { return aField; } set { if (value != null) { aField = value; } } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            F fObj = new F();
            D dObj = new D();
            J jObj = new J();
            B bObj = new B(dObj);
            C cObj = new C(fObj);
            A aObj = new A(bObj, cObj, jObj);
            fObj.a = aObj;
            dObj.a = aObj;
            jObj.a = aObj;

            aObj.aHashCode();
            aObj.b.d.a.aHashCode();
            aObj.c.f.a.aHashCode();
            aObj.j.a.j.a.aHashCode();
            Console.ReadKey();
        }
    }
}
