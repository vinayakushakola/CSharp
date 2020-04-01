using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
    class ProxyProgram
    {
        public static void ProxyRun()
        {
            try
            {
                ICommandExecuter commandExecutor = new ProxyCommandExecuter("Admin", "1234");
                commandExecutor.RunCommand("mkdir Proxy");
                commandExecutor.RunCommand("rm ProxyConcept.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}
