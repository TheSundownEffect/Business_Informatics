using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace WebServer
{
    internal class Requests
    {
        private Queue<TcpClient> queue = new Queue<TcpClient>();

        public void Add(TcpClient client)
        {
            queue.Enqueue(client);
        }

        public void Process(string path)
        {
            while (queue.Count > 0)
            {
                var r = new Request(queue.Dequeue(), path);
                r.Process();
            }
        }
    }
}