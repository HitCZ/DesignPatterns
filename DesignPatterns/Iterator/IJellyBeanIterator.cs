namespace DesignPatterns.Iterator
{
    public interface IJellyBeanIterator
    {
        JellyBean First();
        JellyBean Next();

        bool IsDone { get; }
        JellyBean CurrentBean { get; }
    }
}
