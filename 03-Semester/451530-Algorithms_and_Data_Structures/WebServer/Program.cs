/* * * * * * *
 * Title:   WebServer
 * Class:   Program.cs
 * Author:  Christian B.
 * Date:    02.01.2019
 * 
*/

#region Bibliothek von Alexandria
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace WebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new HttpServer(7777, @"c:\temp");
            server.Start();
        }
    }
}
