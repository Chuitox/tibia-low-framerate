namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1011(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x566890;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.11] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
