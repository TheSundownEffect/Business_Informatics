using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServer
{
    public interface ICollection
    {
        int Count { get; }

        void Clear();
    }
}