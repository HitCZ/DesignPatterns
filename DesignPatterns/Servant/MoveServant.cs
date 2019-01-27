using DesignPatterns.Messenger;

namespace DesignPatterns.Servant
{
    class MoveServant {
        public void MoveTo(IMovable serviced, Position destination) => serviced.Position = destination;

        public void MoveBy(IMovable serviced, double dx, double dy) {
            dx += serviced.Position.X;
            dy += serviced.Position.Y;

            serviced.Position = new Position(dx, dy);
        }
    }
}
