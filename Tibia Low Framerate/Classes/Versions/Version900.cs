namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion900(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x3CCE04;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.0] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
