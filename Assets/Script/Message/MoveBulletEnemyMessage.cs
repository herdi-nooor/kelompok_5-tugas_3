using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Gameplay.Bullet
{
    public struct MoveBulletEnemyMessage
    {
        public Vector2 Direction { get; private set; }

        public MoveBulletEnemyMessage(Vector2 direction)
        {
            Direction = direction;
        }
    }
}

