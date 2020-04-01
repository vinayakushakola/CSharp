using System;

namespace DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
    class ProxyCommandExecuter : ICommandExecuter
    {
        private bool isAdmin;
        private ICommandExecuter executor;

        public ProxyCommandExecuter(string user, string pass)
        {
            if ("Admin".ToLower().Equals(user) && "1234".Equals(pass))
                isAdmin = true;
            executor = new RealCommandExecuter();
        }

        public void RunCommand(string cmd)
        {
            if (isAdmin)
                executor.RunCommand(cmd);
            else
            {
                if (cmd.Trim().StartsWith("rm"))
                    throw new Exception("rm Command is not Allowed!");
                else
                    executor.RunCommand(cmd);
            }
        }
    }
}
