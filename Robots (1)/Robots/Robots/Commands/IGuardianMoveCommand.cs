namespace Robots
{
    public interface IGuardianMoveCommand : IMoveCommand
    {
        bool Guard { get; }
    }
}