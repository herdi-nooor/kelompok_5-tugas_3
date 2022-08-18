using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Message
{
    public struct SpaceshipBulletMessage
    {
        public Vector3 spaceshipPosition { get; private set; }

        public SpaceshipBulletMessage(Vector3 Position)
        {
            spaceshipPosition = Position;
        }
    }

}
