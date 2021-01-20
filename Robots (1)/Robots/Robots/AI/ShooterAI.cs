namespace Robots
{
    public class ShooterAI : IAi<IShooterMoveCommand>
    {
        public IShooterMoveCommand GetCommand()
        {
            var counter = _counter++;
            return new ShooterCommand
            {
                Destination = new Point { X = counter * 2, Y = counter * 3 },
                Shoot = counter % 5 == 0,
                ShouldHide = counter % 3 == 0
            };
        }
        
        private int _counter = 1;
    }
}
