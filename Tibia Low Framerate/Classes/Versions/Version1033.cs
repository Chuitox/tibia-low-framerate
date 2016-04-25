namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1033(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x569810;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.33] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
