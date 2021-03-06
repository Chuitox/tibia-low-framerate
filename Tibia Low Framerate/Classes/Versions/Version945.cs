﻿namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion945(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x58B174;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.45] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
