using UnityEngine;

namespace SpaceInvader.Gameplay.Bullet
{
    public struct MoveBulletMessage
    {
        public Vector2 Direction { get; private set;}

        public MoveBulletMessage(Vector2 direction)
        {
            Direction = direction;
        }
    }
    // message membawa data 
    // contoh Direction
}

