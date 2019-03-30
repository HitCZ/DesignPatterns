namespace DesignPatterns.Iterator
{
    public class JellyBeanIterator : IJellyBeanIterator
    {
        private readonly JellyBeanCollection jellyBeans;
        private int current;
        private int step = 1;

        public JellyBeanIterator(JellyBeanCollection beans)
        {
            jellyBeans = beans;
        }

        public JellyBean First()
        {
            current = 0;

            return jellyBeans[current] as JellyBean;
        }

        public JellyBean Next()
        {
            current += step;

            if (!IsDone)
                return jellyBeans[current] as JellyBean;

            return null;
        }

        public JellyBean CurrentBean => jellyBeans[current] as JellyBean;

        public bool IsDone => current >= jellyBeans.Count;
    }
}
