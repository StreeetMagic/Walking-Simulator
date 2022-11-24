using UnityEngine;

namespace Services.Inputs
{
    public abstract class InputService : IInputService
    {
        private const string Button = "Fire";
        protected const string Horizontal = "Horizontal";
        protected const string Vertical = "Vertical";

        public abstract Vector2 Axis { get; }

        public bool isAttackButtonUp()
        {
            return SimpleInput.GetButtonUp(Button);
        }

        protected static Vector2 SimpleInputAxis()
        {
            return new Vector2(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));
        }
    }
}