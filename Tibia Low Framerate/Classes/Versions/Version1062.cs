namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1062(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x617BF0;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.62] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
