using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Message
{
    public struct SpaceshipBulletMessage
    {
        public Vector2 spaceshipPosition { get; private set; }

        public SpaceshipBulletMessage(Vector2 Position)
        {
            spaceshipPosition = Position;
        }
    }

}
