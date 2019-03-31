namespace DesignPatterns.Facade
{
    public class HardDrive
    {
        public byte[] Read(long lba, int size) => new byte[3];
    }
}
