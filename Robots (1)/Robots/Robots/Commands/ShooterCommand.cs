namespace Robots
{
    public class ShooterCommand : IShooterMoveCommand
    {
        public Point Destination { get; set; }
        public bool Shoot { get; set; }
        public bool ShouldHide { get; set; }
    }
}
