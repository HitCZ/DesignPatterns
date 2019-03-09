namespace DesignPatterns.Command
{
    public interface IDeviceCommand : ICommand
    {
        IDevice Device { get; set; }
    }
}
