namespace DesignPatterns.Facade
{
    class ComputerFacade
    {
        private CPU cpu;
        private Memory memory;
        private HardDrive hdd;

        public ComputerFacade()
        {
            cpu = new CPU();
            memory = new Memory();
            hdd = new HardDrive();
        }

        public void Start()
        {
            cpu.Freeze();
            memory.Load(0215, hdd.Read(20, 2));
            cpu.Jump(0215);
            cpu.Execute();
        }
    }
}
