namespace DesignPatterns.Command
{
    class TurnOnCommand : IDeviceCommand
    {
        public IDevice Device { get; set; }

        public TurnOnCommand(IDevice device)
        {
            Device = device;
        }

        public void Execute() => Device.TurnOn();
    }
}
