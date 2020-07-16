using RaRat_server.Commnucation;
using System;
using System.Threading;

namespace RaRat_server
{
    class Controller
    {
        public Controller() {
            //sendCommand("127.0.0.1", 8080, "Test");
            //startListening();
            SocketServer.StartListening();
        }

        void sendCommand(string IP, int port, string command)
        {
            Thread socketClientThread = new Thread(()=>initSocketClient(IP, port, command));
            socketClientThread.Start();
        }
        void startListening() {
            Thread socketClientThread = new Thread(() => initSocketServer());
            socketClientThread.Start();
        }

        void initSocketClient(string IP, int port, string command) {
            SocketClient socketClient = new SocketClient();
            socketClient.startClient(IP, port, command);
            Console.WriteLine(socketClient.getResponse());
        }
        void initSocketServer()
        {
            SocketServer.StartListening();
        }
    }
}
