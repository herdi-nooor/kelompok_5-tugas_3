using Agate.MVC.Base;
using SpaceInvader.Message;
using SpaceInvader.Module.Spaceship;
using SpaceInvader.Gameplay.Bullet;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private SpaceshipController _spaceship;
        // tambah private bullet
        private BulletController _bullet;
        private BulletEnemyController _bulletEnemy;
        
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
        /*public void OnMoveBullet(MoveBulletMessage message)
        {
            // panggil fungsi yang ada di controller objectnya
            _bullet.OnMoveBullet();
        }*/
        public void OnMoveBulletEnemy(MoveBulletEnemyMessage message)
        {
            _bulletEnemy.OnMoveBulletEnemy();
        }

        public void OnSpaceshipBulletFire(SpaceshipBulletMessage message)
        {
            // isi parameter dengan data yang ada di message message
            _bullet.OnSpaceshipBulletFire(message.spaceshipPosition);
            Debug.Log(message.spaceshipPosition);
        }

        protected override void Connect()
        {
            Subscribe<MoveLeftMessage>(OnMoveLeft);
            Subscribe<MoveRightMessage>(OnMoveRight);
            Subscribe<FireMessage>(OnSpaceshipBullet);

            //subcribe nama Message nya ( memanggi fungsinya ),
            //  menerima message yangn disiarkan dan meneruskan 
            //Subscribe<MoveBulletMessage>(OnMoveBullet);
            Subscribe<SpaceshipBulletMessage>(OnSpaceshipBulletFire);
            Subscribe<MoveBulletEnemyMessage>(OnMoveBulletEnemy);
        }

        protected override void Disconnect()
        {
            Unsubscribe<MoveLeftMessage>(OnMoveLeft);
            Unsubscribe<MoveRightMessage>(OnMoveRight);
            Unsubscribe<FireMessage>(OnSpaceshipBullet);
            //unsubscribe nama fungsi
            //Unsubscribe<MoveBulletMessage>(OnMoveBullet);
            Unsubscribe<MoveBulletEnemyMessage>(OnMoveBulletEnemy);
        }
    }
}

