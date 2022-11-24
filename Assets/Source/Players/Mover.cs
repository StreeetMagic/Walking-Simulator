using Cameras;
using Infrastructure;
using Services;
using Services.Inputs;
using UnityEngine;

namespace Players
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private float _movementSpeed;
        
        private IInputService _inputService;
        private Camera _camera;

        private void Awake()
        {
            _inputService = Game.InputService;
        }

        private void Start()
        {
            _camera = Camera.main;
            FollowCamera();
        }

        private void Update()
        {
            Vector3 movementVector = Vector3.zero;

            if (_inputService.Axis.sqrMagnitude > Constants.Epsilon)
            {
                movementVector = _camera.transform.TransformDirection(_inputService.Axis);
                movementVector.y = 0;
                movementVector.Normalize();

                transform.forward = movementVector;
            }

            movementVector += Physics.gravity;
            
            _characterController.Move(movementVector * (_movementSpeed * Time.deltaTime));
        }

        private void FollowCamera()
        {
            _camera.GetComponent<Follower>().Follow(gameObject);
        }
    }
}
