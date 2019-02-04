using System.Runtime.InteropServices.ComTypes;

namespace DesignPatterns.ObjectPool
{
    public interface IFactory<T>
    {
        T GetNewInstance();
    }
}
