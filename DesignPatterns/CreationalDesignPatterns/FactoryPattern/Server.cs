using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.FactoryPattern
{
    class Server : Computer
    {
        private string CPU;
        private string RAM;
        private string SDD;
        private string HDD;

        public Server(string cpu, string ram, string hdd, string sdd)
        {
            this.CPU = cpu;
            this.RAM = ram;
            this.HDD = hdd;
            this.SDD = sdd;
        }

        public override string GetRAM()
        {
            return this.RAM;
        }
        public override string GetCPU()
        {
            return this.CPU;
        }
        public override string GetHDD()
        {
            return this.HDD;
        }
        public override string GetSDD()
        {
            return this.SDD;
        }
    }
}
