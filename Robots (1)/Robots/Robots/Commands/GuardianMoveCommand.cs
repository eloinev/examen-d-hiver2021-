namespace Robots
{
    public class GuardianMoveCommand : IGuardianMoveCommand
    {
        public Point Destination { get; set; }
        public bool Guard { get; set; }
    }
}