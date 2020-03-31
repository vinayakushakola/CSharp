using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.AdapterDesignPattern
{
    class AdapterProgram
    {
        public static void AdapterRun()
        {

            Console.WriteLine("Output: ");

            Console.WriteLine("\nClass Adapter: ");
            ISocketAdapter socketAdapter = new SocketClassAdapter();
            
            Volt v3 = socketAdapter.Get3Volt();
            Volt v12 = socketAdapter.Get12Volt();
            Volt v120 = socketAdapter.Get120Volt();
            Console.WriteLine("3 Volts Class Adapter: {0}", v3.GetVolts());
            Console.WriteLine("12 Volts Class Adapter: {0}", v12.GetVolts());
            Console.WriteLine("120 Volts Class Adapter: {0}", v120.GetVolts());


            Console.WriteLine("\nObject Adapter: ");
            socketAdapter = new SocketObjectAdapter();

            Volt objV3 = socketAdapter.Get3Volt();
            Volt objV12 = socketAdapter.Get12Volt();
            Volt objV120 = socketAdapter.Get120Volt();
            Console.WriteLine("3 Volts Object Adapter: {0}", objV3.GetVolts());
            Console.WriteLine("12 Volts Object Adapter: {0}", objV12.GetVolts());
            Console.WriteLine("120 Volts Object Adapter: {0}", objV120.GetVolts());
        }
    }
}
