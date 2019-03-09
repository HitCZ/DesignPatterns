namespace DesignPatterns.Command
{
    class TurnOffCommand : IDeviceCommand
    {
        public IDevice Device { get; set; }

        public TurnOffCommand(IDevice device)
        {
            Device = device;
        }

        public void Execute() => Device.TurnOff();
    }
}
