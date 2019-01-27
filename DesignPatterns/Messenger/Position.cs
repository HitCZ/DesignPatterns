namespace DesignPatterns.Messenger
{
    public struct Position
    {
        public Position(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }
    }
}
