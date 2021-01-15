namespace Robots
{
    public interface IShooterMoveCommand : IMoveCommand
    {
        bool Shoot { get; set; }
        bool ShouldHide { get; set; }
    }
}