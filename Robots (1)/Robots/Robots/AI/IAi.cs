namespace Robots
{
    public interface IAi<out TCommand> where TCommand : IMoveCommand
    {
        TCommand GetCommand();
    }
}