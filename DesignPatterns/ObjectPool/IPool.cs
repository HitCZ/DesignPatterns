using System.Threading.Tasks;

namespace DesignPatterns.ObjectPool
{
    public interface IPool<T>
    {
        T GetObjectNow();
        Task<T> GetObjectWhenPossible();
        Task<T> GetAvailableObject();
        void GetInstance(T instance);
    }
}
