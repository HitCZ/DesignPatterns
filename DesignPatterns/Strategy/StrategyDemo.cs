namespace DesignPatterns.Strategy
{
    public static class StrategyDemo
    {
        public static void Run()
        {
            var list = new SortableCollection(new BubbleSortStrategy());
            var manager = new SortStrategyManager();

            for (var i = 0; i < 52; i++)
            {
                list.Add(new Student("John Doe"));
                manager.SetAppropriateStrategy(list);
                list.Sort();
            }
        }
    }
}
