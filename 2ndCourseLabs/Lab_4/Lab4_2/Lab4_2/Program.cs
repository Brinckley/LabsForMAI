using System;

namespace Lab4_2
{
    interface A
    {
        void writer();
    }

    class J : A
    {
        private int j_field;

        public int j_Getter { get; set; }

        public J() { j_field = 2; }

        public void writer() {
            Console.WriteLine("Value of J: " + j_field);
        }
    }


    abstract class B : A
    {
        public abstract void writer();

        public abstract void writer_B();
    }

    abstract class C : A
    {
        public abstract void writer();

        public abstract void writer_C();
    }


    class D : B
    {
        int d_field;

        public D() {
            d_field = 22;
        }

        public D(int d_field)
        {
            this.d_field = d_field;
        }

        public override void writer()
        {
            Console.WriteLine("Value of this field: " + d_field);
        }

        public override void writer_B()
        {
            Console.WriteLine("We've come from D abstract class");
        }
    }

    class F : C
    {
        int f_field;

        public F()
        {
            f_field = 222;
        }

        public F(int f_field)
        {
            this.f_field = f_field;
        }

        public override void writer()
        {
            Console.WriteLine("Value of this field: " + f_field);
        }

        public override void writer_C()
        {
            Console.WriteLine("We've come from C abstract class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            J j_obj = new J();
            j_obj.writer();
            Console.WriteLine();
            
            D d_obj = new D();
            d_obj.writer();
            d_obj.writer_B();
            Console.WriteLine();

            F f_obj = new F();
            f_obj.writer();
            f_obj.writer_C();

            Console.ReadKey();
        }
    }
}
