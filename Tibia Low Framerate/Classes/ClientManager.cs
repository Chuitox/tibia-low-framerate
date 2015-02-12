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
                var clients = new List<Client>();
                foreach (var p in Engine.Processes)
                {
                    var VersionInfo = FileVersionInfo.GetVersionInfo(p.Modules[0].FileName);
                    var newClient = VersionManager.Set(VersionInfo.FileVersion, new Client(p));
                    clients.Add(newClient);
                }
                return clients;
            }
        }
    }
}
