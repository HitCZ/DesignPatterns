namespace DesignPatterns.ObjectPool
{
    class Demo
    {
        public static void Main(string[] args)
        {
            var pool = new ObjectPool<Connection>();
            var connection = pool.Get();
            pool.Release(connection);
        } 
    }
}
