using System.Collections.Generic;

namespace Robots
{
    public class Robot<TCommand> where TCommand : IMoveCommand
    {
        private readonly IAi<TCommand> ai;
        private readonly IMover<TCommand> device;

        public Robot(IAi<TCommand> ai, IMover<TCommand> executor)
        {
            this.ai = ai;
            this.device = executor;
        }

        public IEnumerable<string> Start(int steps)
        {
            for (var i = 0; i < steps; i++)
            {
                var command = ai.GetCommand();
                yield return device.ExecuteCommand(command);
            }
        }
    }

    public static class Robot
    {
        public static Robot<TCommand> Create<TCommand>(IAi<TCommand> ai, IMover<TCommand> executor)
            where TCommand : IMoveCommand
        {
            return new Robot<TCommand>(ai, executor);
        }
    }
}