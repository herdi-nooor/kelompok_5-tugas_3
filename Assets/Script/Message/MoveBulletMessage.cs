using UnityEngine;

namespace SpaceInvander.Gameplay.Bullet
{
    public struct MoveBulletMessage
    {
        public Vector2 Direction { get; private set;}

        public MoveBulletMessage(Vector2 direction)
        {
            Direction = direction;
        }
    }
}

