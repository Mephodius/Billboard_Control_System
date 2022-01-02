using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BBControlSystem
    {
        private Server server;
        private static BBControlSystem system;

        private BBControlSystem()
        {
            server = Server.getInstance();
        }

        public static BBControlSystem getInstance()
        {
            if (system == null)
                system = new BBControlSystem();
            return system;
        }
        public Server getServer()
        {
            return server;
        }
    }
}
