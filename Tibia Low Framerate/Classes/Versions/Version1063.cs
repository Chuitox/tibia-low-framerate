using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1063(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x617BF0;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = String.Format("[10.63] {0} {1} fps", Memory.ReadTitle(client.Process), client.GetFramerate());

            return client;
        }
    }
}
