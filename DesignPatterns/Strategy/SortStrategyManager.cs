namespace DesignPatterns.Strategy
{
    public class SortStrategyManager
    {
        public void SetAppropriateStrategy(ISortableCollection collection)
        {
            var count = collection.Count();

            if (count == 0)
                collection.SetSortStrategy(new BubbleSortStrategy());
            else if (count > 10 && count <= 50)
                collection.SetSortStrategy(new QuickSortStrategy());
            else if (count > 50)
                collection.SetSortStrategy(new MergeSortStrategy());
        }
    }
}
