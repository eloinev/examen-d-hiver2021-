namespace Robots
{
    public class BuilderCommand : IMoveCommand
    {
        public Point Destination { get; set; }
        public bool Build { get; set; }
    }
}
