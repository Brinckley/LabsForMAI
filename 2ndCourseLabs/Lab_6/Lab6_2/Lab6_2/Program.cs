using System;

namespace Lab6_2
{
    class Program
    {
        class A {
            int sizeB;
            B[] bArray;
            int lengthB;
            
            int sizeC;
            C[] cArray;
            int lengthC;
            
            int sizeJ;
            J[] jArray;
            int lengthJ;

            public A() {
                lengthB = 4; bArray = new B[sizeB];
                lengthC = 4; cArray = new C[sizeC];
                lengthJ = 4; jArray = new J[sizeJ];
            }
            public A(int lengthB, int lengthC, int lengthJ) {
                this.lengthB = lengthB; bArray = new B[lengthB];
                this.lengthC = lengthC; cArray = new C[lengthC];
                this.lengthJ = lengthJ; jArray = new J[lengthJ];
            }

            public void AddB(B b) { if (sizeB < lengthB) { bArray[sizeB] = b; sizeB++; } }
            public B GetB(int number) { if (number >= 0 && number < sizeB) { return bArray[number]; } return null; }

            public void AddC(C c) { if (sizeC < lengthC) { cArray[sizeC] = c; sizeC++; } }
            public C GetC(int number) { if (number >= 0 && number < sizeC) { return cArray[number]; } return null; }

            public void AddJ(J j) { if (sizeJ < lengthJ) { jArray[sizeJ] = j; sizeJ++; } }
            public J GetJ(int number) { if (number >= 0 && number < sizeJ) { return jArray[number]; } return null; }

            public void HashCode() { Console.WriteLine("A class hash:  " + this.GetHashCode()); }
        }

        class B {
            int size;
            D[] dArray;
            int length;

            public B() { length = 4; dArray = new D[size]; }
            public B(int length) { this.length = length; dArray = new D[length]; }

            public void Add(D d) { if (size < length) { dArray[size] = d; size++; } }
            public D Get(int number) { if (number >= 0 && number < size) { return dArray[number]; } return null; }

            public void HashCode() { Console.WriteLine("B class hash:  " + this.GetHashCode()); }

        }

        class C {
            int size;
            F[] fArray;
            int length;

            public C() { length = 4; fArray = new F[size]; }
            public C(int length) { this.length = length; fArray = new F[length]; }

            public void Add(F f) { if (size < length) { fArray[size] = f; size++; } }
            public F Get(int number) { if (number >= 0 && number < size) { return fArray[number]; } return null; }

            public void HashCode() { Console.WriteLine("C class hash:  " + this.GetHashCode()); }

        }

        class J
        {
            A aObj;
            public A a { get { return aObj; } set { if (value != null) { aObj = value; } } }

            int JNum;
            public int jNum { get { return JNum; } }

            public J() { }
            public J(A a, int JNum) { this.a = a; this.JNum = JNum; }

            public void HashCode() { Console.WriteLine("J class hash:  " + this.GetHashCode()); }

        }

        class D {
            A aObj;
            public A a { get { return aObj; } set { if (value != null) { aObj = value; } } }

            int DNum;
            public int dNum { get { return DNum; } }

            public D() { }
            public D(A a, int DNum) { this.a = a; this.DNum = DNum; }

            public void HashCode() { Console.WriteLine("D class hash:  " + this.GetHashCode()); }
        }

        class F {
            A aObj;
            public A a { get { return aObj; } set { if (value != null) { aObj = value; } } }

            int FNum;
            public int fNum { get { return FNum; } }

            public F() { }
            public F(A a, int FNum) { this.a = a; this.FNum = FNum; }

            public void HashCode() { Console.WriteLine("F class hash:  " + this.GetHashCode()); }
        }
        static void Main(string[] args)
        {
            F fObj = new F();
            D dObj = new D();
            J jObj = new J();

            C cObj = new C(4);
            cObj.Add(fObj);
            B bObj = new B(4);
            bObj.Add(dObj);

            A aObj = new A(4, 4, 4);
            fObj.a = aObj;
            dObj.a = aObj;
            jObj.a = aObj;

            aObj.AddB(bObj);
            aObj.AddC(cObj);
            aObj.AddJ(jObj);

            aObj.HashCode();
            aObj.GetB(0).Get(0).a.HashCode();
            aObj.GetC(0).Get(0).a.HashCode();
            aObj.GetJ(0).a.HashCode();

            Console.ReadKey();
        }
    }
}
