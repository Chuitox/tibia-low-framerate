﻿namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion983(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x59A0CC;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.83] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
