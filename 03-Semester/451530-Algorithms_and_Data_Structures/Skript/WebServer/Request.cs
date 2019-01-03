using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;

namespace WebServer
{
    public class Request
    {
        private string path;
        private TcpClient tcpClient;

        public Request(TcpClient tcpClient, string path)
        {
            this.tcpClient = tcpClient;
            this.path = path;
            Header = new List<string>();
        }

        public List<string> Header
        {
            get; private set;
        }

        public string HttpVersion
        {
            get; private set;
        }

        public string LocalUrl
        {
            get; private set;
        }

        public void Process()
        {
            try
            {
                using (var r = new StreamReader(tcpClient.GetStream()))
                using (var w = new StreamWriter(tcpClient.GetStream()))
                {
                    var line = r.ReadLine(); // GET /index.html HTTP/1.0
                    string[] tokens = line.Split(' ');
                    HttpVersion = tokens[2];
                    LocalUrl = tokens[1];

                    while ((line = r.ReadLine()) != null)
                    {
                        Header.Add(line);
                        if (r.Peek() == -1)
                            break;
                    }

                    string filename = Path.Combine(path, LocalUrl.Replace("/", ""));
                    string content = File.ReadAllText(filename);

                    w.WriteLine("HTTP/1.0 200 ok");
                    w.WriteLine("Content-Type: text/html");
                    w.WriteLine("Connection: close");
                    w.WriteLine();
                    w.WriteLine(content);
                }
            }
            catch
            { }
        }
    }
}