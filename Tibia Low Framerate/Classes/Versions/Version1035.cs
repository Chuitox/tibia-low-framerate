﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1035(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x569810;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = String.Format("[10.35] {0} {1} fps", Memory.ReadTitle(client.Process), client.GetFramerate());

            return client;
        }
    }
}
