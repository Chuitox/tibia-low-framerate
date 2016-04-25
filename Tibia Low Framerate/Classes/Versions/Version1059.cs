namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1059(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x60F8C4;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.59] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
