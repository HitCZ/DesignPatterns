using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class VolumeUpCommand : IDeviceCommand
    {
        public IDevice Device { get; set; }

        public VolumeUpCommand(IDevice device)
        {
            Device = device;
        }

        public void Execute() => Device.VolumeUp();
    }
}
