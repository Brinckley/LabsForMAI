using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    
    //expansion
    class A
    {
        protected int a_num;

        public int A_num { get; set; }

        public A() {
            a_num = 2;
        }

        public virtual void writer() {
            Console.WriteLine("In A superclass method. Value: " + a_num);
        }
    }
    
    class C : A
    {
        protected int c_num;

        public int C_num { get; set; }

        public C()
        {
            c_num = 222;
        }

        public new void writer()
        {
            Console.WriteLine("In С expansion method. Values: " + a_num + ", " + c_num);
        }

        public void writer_C()
        {
            Console.WriteLine("In С own method. Values: " + a_num + ", " + c_num);
        }
    }


    //specification
    interface C_Interface
    {
        void writer();
    }

    class D_class : C_Interface
    {
        protected int d_num;

        public int D_num { get; set; }

        public D_class()
        {
            d_num = 22;
        }
        
        public void writer()
        {
            Console.WriteLine("In D specification method. Value: " + d_num);
        }
    }

    
    //specialization
    class B_class {
        protected int b_class_num;

        public B_class() {
            b_class_num = 2222;
        }
        
        public virtual void writer() {
            Console.WriteLine("Parent specialization function");
        }
    }
    
    class F_class : B_class {

        protected int f_class_num;

        public F_class() {
            f_class_num = 22222;
        }
        
        public new void writer() {
            Console.WriteLine("In F_class specification method.Values: " + f_class_num + ", " + b_class_num);
        }
    }


    //constructor, combination
    interface A_interface
    {
        void printing1();
        int numberReturner();
    }

    interface B_interface
    {
        void printing2();
        string stringReturner();
    }

    class J_class : A_interface, B_interface
    {
        private int j_field;
        private string j_string;

        public J_class() {
            j_field = 22222;
            j_string = "222222";
        }

        public void intro() {
            Console.WriteLine("Constructor, Combination");
        }

        public int numberReturner()
        {
            return j_field;
        }

        public void printing1()
        {
            Console.WriteLine("String and number = " + j_field + " " + j_string);
        }

        public void printing2()
        {
            Console.WriteLine("String & number = " + j_field  + " " + j_string);
        }

        public string stringReturner()
        {
            return j_string;
        }
    }

}
