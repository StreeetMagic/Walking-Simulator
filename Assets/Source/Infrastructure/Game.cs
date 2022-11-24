using Services.Inputs;

namespace Infrastructure
{
    internal class Game
    {
        public static IInputService InputService;
        public readonly GameStateMachine StateMachine;

        public Game()
        {
            StateMachine = new GameStateMachine();
        }

    }
}