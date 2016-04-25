namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1056(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x6007BC;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.56] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
