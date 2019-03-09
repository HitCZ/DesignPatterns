namespace DesignPatterns.Command
{
    class VolumeDownCommand : IDeviceCommand
    {
        public IDevice Device { get; set; }

        public void Execute() => Device.VolumeDown();
    }
}
