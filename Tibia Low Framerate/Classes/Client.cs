using System;
using System.Diagnostics;

namespace TLF
{
    class Client
    {
        public Client(Process process)
        {
            Process = process;
        }

        public ushort Version { get; set; }
        public string Text { get; set; }
        public int FramerateBaseAddress { get; set; }
        public int Offset { get; set; }
        public Process Process { get; set; }

        public void SetFramerate(double framerate)
        {
            var processHandle = WinApi.OpenProcess(WinApi.PROCESS_ALL_ACCESS, false, Process.Id);
            var baseFramerate = Memory.ReadInt32(processHandle, ((IntPtr)(Process.MainModule.BaseAddress.ToInt64() + FramerateBaseAddress)));
            var memoryAddress = ((IntPtr)(baseFramerate + Offset));

            framerate = ((int)(1000 / framerate));
            var array = BitConverter.GetBytes(framerate);
            UIntPtr bytesWritten;
            WinApi.WriteProcessMemory(processHandle, memoryAddress, array, (uint)array.Length, out bytesWritten);
        }

        public double GetFramerate()
        {
            var processHandle = WinApi.OpenProcess(WinApi.PROCESS_ALL_ACCESS, false, Process.Id);
            var baseFramerate = Memory.ReadInt32(processHandle, ((IntPtr)(Process.MainModule.BaseAddress.ToInt64() + FramerateBaseAddress)));
            var memoryAddress = ((IntPtr)(baseFramerate + Offset));
            var currentFramerate = Memory.ReadDouble(processHandle, memoryAddress);
            return ((int)(1000 / currentFramerate));
        }
    }
}
