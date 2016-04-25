namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion953(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x58D1BC;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[9.53] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
