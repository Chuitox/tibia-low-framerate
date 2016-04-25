namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1064(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x617C1C;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.64] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
