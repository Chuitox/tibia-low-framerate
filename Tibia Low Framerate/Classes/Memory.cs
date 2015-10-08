using System;
using System.Diagnostics;

namespace TLF
{
    class Memory
    {
        public static string ReadTitle(Process process)
        {
            const string removeString = "Tibia - ";
            var index = process.MainWindowTitle.IndexOf(removeString, StringComparison.Ordinal);
            return (index < 0) ? process.MainWindowTitle : process.MainWindowTitle.Remove(index, removeString.Length);
        }

        public static Int32 ReadInt32(IntPtr hProcess, IntPtr dwAddress)
        {
            var buffer = new byte[4];
            int bytesread;

            WinApi.ReadProcessMemory(hProcess, dwAddress, buffer, 4, out bytesread);
            return BitConverter.ToInt32(buffer, 0);
        }

        public static double ReadDouble(IntPtr hProcess, IntPtr dwAddress)
        {
            var buffer = new byte[8];
            int bytesread;

            WinApi.ReadProcessMemory(hProcess, dwAddress, buffer, 8, out bytesread);
            return BitConverter.ToDouble(buffer, 0);
        }
    }
}
