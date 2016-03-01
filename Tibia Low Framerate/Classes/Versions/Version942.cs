namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion942(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x58B6B8;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = string.Format("[9.42] {0} {1} fps", Memory.ReadTitle(client.Process), client.GetFramerate());

            return client;
        }
    }
}
