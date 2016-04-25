namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1000(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x565890;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.00] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
