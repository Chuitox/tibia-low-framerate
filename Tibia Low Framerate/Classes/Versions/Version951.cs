namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion951(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x58C1A4;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.51] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
