namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1094(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x7268B0;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.94] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
