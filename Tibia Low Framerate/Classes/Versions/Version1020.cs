namespace TLF
{
    partial class VersionManager
    {
        public static Client SetVersion1020(Client client)
        {
            // Update instance
            client.FramerateBaseAddress = 0x5688D0;
            client.Offset = 0x58;
            client.Version = CurrentVersion;

            // Update text to be displayed
            client.Text = $"[10.20] {Memory.ReadTitle(client.Process)} {client.GetFramerate()} fps";

            return client;
        }
    }
}
