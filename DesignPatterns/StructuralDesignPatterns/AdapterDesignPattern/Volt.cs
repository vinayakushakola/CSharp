using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.AdapterDesignPattern
{
    public class Volt
    {
        private int volts;

        public Volt(int volt)
        {
            this.volts = volt;
        }

        public int GetVolts()
        {
            return volts;
        }

        public void SetVolts(int volts)
        {
            this.volts = volts;
        }

    }
}
