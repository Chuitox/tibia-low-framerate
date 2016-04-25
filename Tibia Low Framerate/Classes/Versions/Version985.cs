namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion985(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x59D744;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.85] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
