namespace Robots
{
    public class Mover : IMover<IMoveCommand>
    {
        public string ExecuteCommand(IMoveCommand command)
        {
            return $"MOV {command.Destination.X}, {command.Destination.Y}";
        }
    }
}