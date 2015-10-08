using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TLF
{
    class Engine
    {
        public static List<Process> Processes
        {
            get
            {
                return Process.GetProcessesByName("Tibia").ToList();
            }
        }
    }
}
