namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion981(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x5960CC;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.81] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
