using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace TLF
{
    class Client
    {
        public Client(Process process)
        {
            this.Process = process;
        }

        public ushort Version { get; set; }
        public string Text { get; set; }
        public int FramerateBaseAddress { get; set; }
        public int Offset { get; set; }
        public Process Process { get; set; }

        public void SetFramerate(double framerate)
        {
            IntPtr processHandle = WinApi.OpenProcess(WinApi.PROCESS_ALL_ACCESS, false, this.Process.Id);
            int baseFramerate = Memory.ReadInt32(processHandle, ((IntPtr)(this.Process.MainModule.BaseAddress.ToInt64() + this.FramerateBaseAddress)));
            IntPtr memoryAddress = ((IntPtr)(baseFramerate + this.Offset));

            framerate = ((int)(1000 / framerate));
            byte[] array = BitConverter.GetBytes(framerate);
            UIntPtr bytesWritten;
            WinApi.WriteProcessMemory(processHandle, memoryAddress, array, (uint)array.Length, out bytesWritten);
        }

        public double GetFramerate()
        {
            IntPtr processHandle = WinApi.OpenProcess(WinApi.PROCESS_ALL_ACCESS, false, this.Process.Id);
            int baseFramerate = Memory.ReadInt32(processHandle, ((IntPtr)(this.Process.MainModule.BaseAddress.ToInt64() + this.FramerateBaseAddress)));
            IntPtr memoryAddress = ((IntPtr)(baseFramerate + this.Offset));
            double currentFramerate = Memory.ReadDouble(processHandle, memoryAddress);
            return ((int)(1000 / currentFramerate));
        }
    }
}
