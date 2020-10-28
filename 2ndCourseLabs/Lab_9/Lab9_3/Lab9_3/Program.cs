using System;

namespace Lab9_3
{
    public class Publisher
    {
        public Publisher() { }
        public Publisher(int number) { this.number = number; }

        private int number;
        public int Number { get { return number; }
            set {
                if (changeEvent != null) { changeEvent("Field has been changed!", value); }
                number = value;
            }
        }

        public void changeValue(int Number) {
            this.Number = Number;
        }

        public delegate void ChangeHandler(string tmp, int newValue);
        public event ChangeHandler changeEvent;

    }

    public class Subscriber
    {
        private Publisher publisher = null;
        private int num;

        public Subscriber(Publisher publisher, int num) {
            this.publisher = publisher;
            this.num = num;
            this.publisher.changeEvent += ChangeEventHandler;
        }

        public void ChangeFunctionCaller(int tmp) {
            publisher.changeValue(tmp);
        }

        public void ChangeEventHandler(string msg, int newValue) {
            Console.WriteLine(msg);
            Console.WriteLine("New value for publishers field is " + newValue);
            Console.WriteLine("From subscriber number " + num);
        }
    }

    class AnotherSubscriber {
        private Publisher publisher = null;
        private int num;

        public AnotherSubscriber(Publisher publisher, int num) {
            this.publisher = publisher;
            this.num = num;
            this.publisher.changeEvent += ChangeEventHandler;
        }

        public void ChangeFunctionCaller(int tmp) {
            publisher.changeValue(tmp);
        }

        public void ChangeEventHandler(string msg, int newValue) {
            Console.WriteLine(msg);
            Console.WriteLine("New value for publishers field is " + newValue);
            Console.WriteLine("From another subscriber with number " + num);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher(55);
            Subscriber subscriber = new Subscriber(publisher, 1);
            AnotherSubscriber anotherSubscriber = new AnotherSubscriber(publisher, 2);

            subscriber.ChangeFunctionCaller(66);
            Console.WriteLine();
            anotherSubscriber.ChangeFunctionCaller(78);

            Console.ReadKey();
        }
    }
}
