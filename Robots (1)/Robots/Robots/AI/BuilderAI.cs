namespace Robots
{
    public class BuilderAI : IAi<BuilderCommand>
    {
        public BuilderCommand GetCommand()
        {
            var counter = _counter++;
            return new BuilderCommand
            {
                Destination = new Point { X = counter, Y = counter },
                Build = counter % 10 == 0
            };
        }
        
        private int _counter = 1;
    }
}
