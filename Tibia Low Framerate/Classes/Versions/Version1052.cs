﻿namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1052(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x5EAB3C;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.52] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
