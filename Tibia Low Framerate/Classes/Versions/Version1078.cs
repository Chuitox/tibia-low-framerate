using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1078(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x61D6BC;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = String.Format("[10.78] {0} {1} fps", Memory.ReadTitle(client.Process), client.GetFramerate());

            return client;
        }
    }
}
