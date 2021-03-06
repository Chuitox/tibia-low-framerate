﻿namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion950(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x58C18C;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.50] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
