namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion910(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x46D448;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.10] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
