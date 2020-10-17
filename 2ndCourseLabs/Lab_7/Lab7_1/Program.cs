using System;

namespace Lab7_1
{

    class Server {
        public Server() {}

        public int serverReturner() {
            return 1;
        }
    }

    static class Utility {
        public static int staticReturner() {
            return 11;
        }
    }

    class Client {
        public Client() { }

        public void serverWriter(Server server) { Console.WriteLine("Client calls server function: " + server.serverReturner()); }
        public void staticReturner() { Console.WriteLine("Cleint calls utility: " + Utility.staticReturner()); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Server server = new Server();

            client.serverWriter(server);
            client.staticReturner();

            Console.ReadKey();
        }
    }
}
