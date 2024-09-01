using SocketsPingPong2;
using System;

class Program
{
    static void Main(string[] args)
    {
        ServerSide serverSide = new ServerSide();
        serverSide.StartServer();
    }
}
