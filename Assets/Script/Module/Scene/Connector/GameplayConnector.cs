using Agate.MVC.Base;
using SpaceInvader.Message;
using SpaceInvader.Module.Spaceship;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private SpaceshipController _spaceship;
        
        public void OnMoveLeft(MoveLeftMessage message)
        {
            _spaceship.OnMoveLeft();
        }

        public void OnMoveRight(MoveRightMessage message)
        {
            _spaceship.OnMoveRight();
        }

        public void OnSpaceshipBullet(FireMessage message)
        {
            _spaceship.OnSpaceshipBullet();
        }

        protected override void Connect()
        {
            Subscribe<MoveLeftMessage>(OnMoveLeft);
            Subscribe<MoveRightMessage>(OnMoveRight);
            Subscribe<FireMessage>(OnSpaceshipBullet);
        }

        protected override void Disconnect()
        {
            Unsubscribe<MoveLeftMessage>(OnMoveLeft);
            Unsubscribe<MoveRightMessage>(OnMoveRight);
            Unsubscribe<FireMessage>(OnSpaceshipBullet);
        }
    }
}

