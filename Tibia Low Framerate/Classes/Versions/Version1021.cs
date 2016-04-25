namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1021(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x5698E8;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.21] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
