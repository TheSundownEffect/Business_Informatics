using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WebServer
{
    public class HttpServer
    {
        public HttpServer(int port, string path)
        {
            Port = port;
            Path = path;
        }

        public string Path
        {
            get;
            private set;
        }

        public int Port
        {
            get; private set;
        }

        public void Start()
        {
            var listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 7777);
            listener.Start();
            var requests = new Requests();
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                requests.Add(client);
                if (listener.Pending() == false)
                {
                    requests.Process(Path);
                }
            }
        }
    }
}