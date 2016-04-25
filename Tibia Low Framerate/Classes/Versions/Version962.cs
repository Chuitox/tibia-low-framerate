namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion962(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x592008;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.62] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
