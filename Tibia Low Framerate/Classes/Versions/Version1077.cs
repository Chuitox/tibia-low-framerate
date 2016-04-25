namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1077(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x61D73C;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.77] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
