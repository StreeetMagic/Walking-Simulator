using Unity.VisualScripting;
using UnityEngine;

namespace Cameras
{
    public class Follower : MonoBehaviour
    {
        [SerializeField] private Transform _following;
        [SerializeField] private float _rotationAngelX;
        [SerializeField] private float _distance;
        [SerializeField] private float _offsetY;

        private void LateUpdate()
        {
            if (_following == null)
            {
                return;
            }

            var rotation = Quaternion.Euler(_rotationAngelX, 0, 0);

            var position = rotation * new Vector3(0, 0, -_distance) + FollowingPosition();

            transform.rotation = rotation;
            transform.position = position;
        }
        

        private Vector3 FollowingPosition()
        {
            Vector3 followingPosition = _following.position;
            followingPosition.y += _offsetY;

            return followingPosition;
        }

        public void Follow(GameObject following)
        {
            _following = following.transform;
        }
    }
}