namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion984(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x59D744;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.84] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
