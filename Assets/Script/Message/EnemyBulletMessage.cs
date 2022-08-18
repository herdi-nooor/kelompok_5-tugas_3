using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceInvader.Message
{
    public struct EnemyBulletMessage
    {
        public Vector3 EnemyPosition { get; private set; }

        public EnemyBulletMessage(Vector3 Position)
        {
            EnemyPosition = Position;
        }
    }
}

