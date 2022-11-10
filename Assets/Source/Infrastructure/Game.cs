using Source.Services.Inputs;
using UnityEngine.WSA;
using Application = UnityEngine.Device.Application;

namespace Source.Infrastructure
{
    internal class Game
    {
        public static IInputService InputService;

        public Game()
        {
            ReisterInputService();
        }

        private static void ReisterInputService()
        {
            if (Application.isEditor)
            {
                InputService = new StandaloneInputService();
            }
            else
            {
                InputService = new MobileInputService();
            }
        }
    }
}