namespace DesignPatterns.State
{
    public class StateDemo
    {
        public StateDemo()
        {
            var player = new Player();
            var enemy = new Enemy();

            player.Move(); // full HP
            enemy.AttackPlayer(player);
            player.Move(); // hurt
            enemy.AttackPlayer(player);
            player.Move(); // dead
        }
    }
}
