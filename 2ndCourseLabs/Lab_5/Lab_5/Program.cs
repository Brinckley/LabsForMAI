using System;

namespace Lab_5
{

    interface A {
        void writer();

        int count_returner();
    }

    class B {
        int b_num;

        public B() { b_num = 3; }
        public B(int b_num) { this.b_num = b_num; }

        public int b_getter { get { return b_num; } }

        public virtual void value_writer() { Console.WriteLine("Value from the object: " + b_num); }
    }

    class D : B, A
    {
        int d_num;

        public D() { d_num = 33; }
        public D(int d_num, int b_num) : base(b_num) { this.d_num = d_num; }

        public int a_getter { get { return d_num; } }

        public int count_returner() {
            d_num++;
            return d_num;
        }

        public void writer() { Console.WriteLine("In D class!"); }

        public new void value_writer() { Console.WriteLine("Values from the class: " + d_num + ", " + b_getter); }
    }

    class C
    {
        int c_num;

        public C() { c_num = 333; }
        public C(int c_num) { this.c_num = c_num; }

        public int c_getter { get { return c_num; } }

        public void value_writer() { Console.WriteLine("Value from the object: " + c_num); }
    }

    class F : C, A
    {
        int f_num;

        public F() { f_num = 3333; }
        public F(int f_num, int c_num) : base(c_num) { this.f_num = f_num; }

        public int f_getter { get { return f_num; } }

        public int count_returner()
        {
            f_num++;
            return f_num;
        }

        public void writer() { Console.WriteLine("In F class!"); }

        public void all_value_writer() { Console.WriteLine("Values from the class: " + f_num + ", " + c_getter); }
    }

    class J : A
    {
        public int count_returner() {
            return 1;
        }

        public void writer() {
            Console.WriteLine("Here in empty J class method....");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a_interfaceObject = null;
            a_interfaceObject = new D(1, 2);
            a_interfaceObject.writer();
            Console.WriteLine("Values of D class:  " + a_interfaceObject.count_returner());
            Console.WriteLine();

            F fObject = new F(4, 5);
            fObject.value_writer();
            fObject.all_value_writer();
            Console.WriteLine("Values of D class:  " + fObject.count_returner());
            Console.WriteLine();

            J jObject = new J();
            jObject.writer();
            Console.WriteLine("Values of J class:  " + jObject.count_returner());
            Console.WriteLine();

            Console.ReadKey();
            
        }
    }
}
