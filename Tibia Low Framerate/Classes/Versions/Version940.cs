namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion940(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x48D738;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.40] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
