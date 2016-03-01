namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1041(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x574880;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = string.Format("[10.41] {0} {1} fps", Memory.ReadTitle(client.Process), client.GetFramerate());

            return client;
        }
    }
}
