using System;

namespace DesignPatterns.Command
{
    class Television : IDevice
    {
        private int volume;
        private const int MAX_VOLUME = 10;

        public void TurnOn()
        {
            Console.WriteLine("Turning TV on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning TV off.");
        }

        public void VolumeUp()
        {
            Console.WriteLine(volume >= MAX_VOLUME ? "Volume is at the maximum." : $"Turning volume up: {++volume}");
        }

        public void VolumeDown()
        {
            Console.WriteLine(volume <= 0 ? "Volume is at the minimum." : $"Turning volume down: {--volume}");
        }
    }
}
