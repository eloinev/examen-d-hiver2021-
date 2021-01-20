namespace Robots
{
    public interface IMover<in TCommand> where TCommand : IMoveCommand
    {
        string ExecuteCommand(TCommand command);
    }
}