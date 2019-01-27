namespace DesignPatterns.Servant
{
    class Main {
        public static void main(string[] args) {
            var triangle = new Triangle();
            var ellipse = new Ellipse();
            var servant = new MoveServant();

            servant.MoveBy(triangle, 5, 5);
            servant.MoveBy(ellipse, 50, 5);

        }
    }
}
