namespace Robots
{
    public class ShooterMover : IMover<IShooterMoveCommand>
    {
        public string ExecuteCommand(IShooterMoveCommand command)
        {
            var hide = command.ShouldHide ? "YES" : "NO";
            var shoot = command.Shoot ? "YES" : "NO";
            return $"MOV {command.Destination.X}, {command.Destination.Y}, FIRE {shoot}, USE COVER {hide}";
        }
    }
}