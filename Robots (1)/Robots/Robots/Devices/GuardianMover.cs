namespace Robots
{
    public class GuardianMover : IMover<IGuardianMoveCommand>
    {
        public string ExecuteCommand(IGuardianMoveCommand command)
        {
            var guard = command.Guard ? "YES" : "NO";
            return $"MOV {command.Destination.X}, {command.Destination.Y}, GUARD {guard}";
        }
    }
}