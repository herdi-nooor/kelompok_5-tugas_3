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
        // tambah private bullet
        
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
        //buat fungsi baru
        // panggil bullet disini

        protected override void Connect()
        {
            Subscribe<MoveLeftMessage>(OnMoveLeft);
            Subscribe<MoveRightMessage>(OnMoveRight);
            Subscribe<FireMessage>(OnSpaceshipBullet);
            //subcribe nama fungsi
        }

        protected override void Disconnect()
        {
            Unsubscribe<MoveLeftMessage>(OnMoveLeft);
            Unsubscribe<MoveRightMessage>(OnMoveRight);
            Unsubscribe<FireMessage>(OnSpaceshipBullet);
            //unsubscribe nama fungsi
        }
    }
}

