using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.FactoryPattern
{
    public abstract class Computer
    {
        public abstract string GetRAM();
        public abstract string GetHDD();
        public abstract string GetCPU();
        public abstract string GetSDD();
    }
}
