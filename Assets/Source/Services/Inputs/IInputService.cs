using UnityEngine;

namespace Source.Services.Inputs
{
    public interface IInputService
    {
        Vector2 Axis { get; }
        bool isAttackButtonUp();
    }
}