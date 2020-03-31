using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.AdapterDesignPattern
{
    class Socket
    {
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }
}
