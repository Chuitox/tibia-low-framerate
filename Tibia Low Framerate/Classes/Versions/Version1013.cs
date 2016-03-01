namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1013(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x567890;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = string.Format("[10.13] {0} {1} fps", Memory.ReadTitle(client.Process), client.GetFramerate());

            return client;
        }
    }
}
