namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion946(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x58B174;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.46] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
