using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace TLF
{
    class Memory
    {
        public static string ReadTitle(Process process)
        {
            var RemoveString = "Tibia - ";
            var Index = process.MainWindowTitle.IndexOf(RemoveString);
            return (Index < 0) ? process.MainWindowTitle : process.MainWindowTitle.Remove(Index, RemoveString.Length);
        }

        public static Int32 ReadInt32(IntPtr hProcess, IntPtr dwAddress)
        {
            var buffer = new byte[4];
            var bytesread = 0;

            WinApi.ReadProcessMemory(hProcess, dwAddress, buffer, 4, out bytesread);
            return BitConverter.ToInt32(buffer, 0);
        }

        public static double ReadDouble(IntPtr hProcess, IntPtr dwAddress)
        {
            var buffer = new byte[8];
            var bytesread = 0;

            WinApi.ReadProcessMemory(hProcess, dwAddress, buffer, 8, out bytesread);
            return BitConverter.ToDouble(buffer, 0);
        }
    }
}
