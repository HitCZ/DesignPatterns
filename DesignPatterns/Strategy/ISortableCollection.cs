namespace DesignPatterns.Strategy
{
    public interface ISortableCollection
    {
        int Count();
        void SetSortStrategy(SortStrategy strategy);
        void Sort();
    }
}
