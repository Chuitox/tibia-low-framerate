using System.Collections.Generic;
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
                    var versionInfo = FileVersionInfo.GetVersionInfo(p.Modules[0].FileName);
                    var newClient = VersionManager.Set(versionInfo.FileVersion, new Client(p));
                    clients.Add(newClient);
                }
                return clients;
            }
        }
    }
}
