using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.AdapterDesignPattern
{
    public interface ISocketAdapter
    {
        public Volt Get120Volt();
        public Volt Get12Volt();
        public Volt Get3Volt();
    }
}
