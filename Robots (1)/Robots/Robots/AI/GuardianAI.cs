namespace Robots
{
    public class GuardianAI : IAi<IGuardianMoveCommand>
    {
        public IGuardianMoveCommand GetCommand()
        {
            var counter = _counter++;
            return new GuardianMoveCommand
            {
                Destination = new Point { X = counter * 0.5, Y = counter * 0.5 },
                Guard = counter % 2 == 0
            };
        }
        
        private int _counter = 1;
    }
}