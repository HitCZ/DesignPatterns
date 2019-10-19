namespace DesignPatterns.Decorator
{
    public interface IBackendProvider<T>
    {
        T CreateOrUpdate(T obj);
        bool Delete(T obj);
    }
}
