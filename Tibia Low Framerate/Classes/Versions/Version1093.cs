namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1093(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x720D14;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.93] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
