using System;

namespace Lab8_2
{
    interface Letter {
        void print();
        void getHashCode();
    }

    class A<T> : Letter
    {
        public T a_t { get; set; }
        private B<T> a_b;

        public B<T> A_B { get { return a_b; } set { if (value != null) { a_b = value; } } }

        public A(T a_t, B<T> a_b) {
            this.a_t = a_t;
            this.a_b = a_b;
        }

        public B<T> next() { return A_B; }

        public void print() { Console.WriteLine("In class A. Value: " + a_t); }
        public void getHashCode() { Console.WriteLine("Hash of A: " + this.GetHashCode()); }
    }

    class B<T> : Letter
    {
        public T b_t { get; set; }
        private C<T> b_c;

        public C<T> B_C { get { return b_c; } set { if (value != null) { b_c = value; } } }

        public B(T b_t, C<T> b_c)
        {
            this.b_t = b_t;
            this.b_c = b_c;
        }

        public C<T> next() { return B_C; }

        public void print() { Console.WriteLine("In class B. Value: " + b_t); }
        public void getHashCode() { Console.WriteLine("Hash of B: " + this.GetHashCode()); }
    }
    
    class C<T> : Letter
    {
        public T c_t { get; set; }

        public C(T c_t) { this.c_t = c_t; }

        public void print() { Console.WriteLine("In class C. Value: " + c_t); }
        public void getHashCode() { Console.WriteLine("Hash of C: " + this.GetHashCode()); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Letter letter;
            C<int> c_obj = new C<int>(1);
            B<int> b_obj = new B<int>(2, c_obj);
            A<int> a_obj = new A<int>(3, b_obj);


            a_obj.print();
            b_obj.print();
            c_obj.print();
            Console.WriteLine();

            a_obj.A_B.B_C.getHashCode();
            c_obj.getHashCode();
            Console.WriteLine();

            letter = a_obj;
            letter.print();

            Console.ReadKey();
        }
    }
}
