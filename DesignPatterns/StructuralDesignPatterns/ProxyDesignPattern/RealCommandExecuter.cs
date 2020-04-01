using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
    class RealCommandExecuter : ICommandExecuter
    {
        public void RunCommand(string cmd)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.CreateNoWindow = true;
            start.FileName = "cmd.exe";
            start.Arguments = cmd;

            Process process = new Process();
            process.StartInfo = start;
            process.Start();
            Console.WriteLine("{0} - Command Executed", cmd);
        }
    }
}
