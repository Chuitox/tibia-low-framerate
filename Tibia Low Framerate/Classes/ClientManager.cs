using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace TLF
{
    class ClientManager
    {
        public static List<Client> Clients
        {
            get
            {
                List<Client> clients = new List<Client>();
                foreach (Process p in Engine.Processes)
                {
                    FileVersionInfo VersionInfo = FileVersionInfo.GetVersionInfo(p.Modules[0].FileName);
                    Client newClient = VersionManager.Set(VersionInfo.FileVersion, new Client(p));
                    clients.Add(newClient);
                }
                return clients;
            }
        }
    }
}
