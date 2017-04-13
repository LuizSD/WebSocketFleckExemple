using Fleck;
using System;

namespace consocket
{
    class Program
    {
        static void Main(string[] args)
        {

            var server = new WebSocketServer("ws://0.0.0.0:8181");
            server.Start(socket =>
            {
                socket.OnOpen = () => Console.WriteLine("Open!");
                socket.OnMessage = message => { Console.WriteLine(message); };
            });

            Console.ReadKey();


        
}
    }
}
