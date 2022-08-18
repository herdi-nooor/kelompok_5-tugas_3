using Agate.MVC.Base;
using SpaceInvader.Message;
using SpaceInvader.Module.Spaceship;
using SpaceInvader.Gameplay.Bullet;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Module.ScoreHandler;
using SpaceInvader.Module.LivesHandler;
using SpaceInvader.Module.UI;
using SpaceInvader.Module.EnemyPool;

namespace SpaceInvader.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private SpaceshipController _spaceship;
        // tambah private bullet
        private BulletController _bullet;
        private BulletEnemyController _bulletEnemy;
        private ScoreHandlerController _scoreHandler;
        private LivesHandlerController _livesHandler;
        private UIController _uI;
        private EnemyPoolController _enemyPool;
//        private UIController _uIController;
        
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
        }*//*
        public void OnMoveBulletEnemy(MoveBulletEnemyMessage message)
        {
            _bulletEnemy.OnMoveBulletEnemy();
        }*/

        public void OnSpaceshipBulletFire(SpaceshipBulletMessage message)
        {
            // isi parameter dengan data yang ada di message message
            _bullet.OnSpaceshipBulletFire(message.spaceshipPosition);
        }
        public void OnEnemyBulletFire(EnemyBulletMessage message)
        {
            // isi parameter dengan data yang ada di message message
            Debug.Log(_bulletEnemy); //null
            _bulletEnemy.OnEnemyBulletFire(message.EnemyPosition);
        }

        public void OnScored(AddScoreMessage message)
        {
            _scoreHandler.OnEnemyDestroyed();
        }

        public void OnGameOver(GameOverMessage message)
        {
            _scoreHandler.OnGameOver();
        }

        public void OnSpaceshipHit(LoseLivesMessage message)
        {
            _livesHandler.OnSpaceshipHit();
        }

        public void OnScoreUpdate(UpdateScoreMessage message)
        {
            _uI.OnScoreUpdate(message.Score);
        }

        public void OnLivesUpdate(UpdateLivesMessage message)
        {
            _uI.OnLivesUpdate(message.Lives);
        }

        public void OnEdge(OnEdgeMessage message)
        {
            _enemyPool.OnEdge();
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
            Subscribe<EnemyBulletMessage>(OnEnemyBulletFire);
            Subscribe<AddScoreMessage>(OnScored);
            Subscribe<GameOverMessage>(OnGameOver);
            Subscribe<LoseLivesMessage>(OnSpaceshipHit);
            Subscribe<UpdateScoreMessage>(OnScoreUpdate);
            Subscribe<UpdateLivesMessage>(OnLivesUpdate);
            Subscribe<OnEdgeMessage>(OnEdge);
        }

        protected override void Disconnect()
        {
            Unsubscribe<MoveLeftMessage>(OnMoveLeft);
            Unsubscribe<MoveRightMessage>(OnMoveRight);
            Unsubscribe<FireMessage>(OnSpaceshipBullet);
            //unsubscribe nama fungsi
            Unsubscribe<SpaceshipBulletMessage>(OnSpaceshipBulletFire);
            Unsubscribe<EnemyBulletMessage>(OnEnemyBulletFire);
            Unsubscribe<AddScoreMessage>(OnScored);
            Unsubscribe<GameOverMessage>(OnGameOver);
            Unsubscribe<LoseLivesMessage>(OnSpaceshipHit);
            Unsubscribe<UpdateScoreMessage>(OnScoreUpdate);
            Unsubscribe<UpdateLivesMessage>(OnLivesUpdate);
            Unsubscribe<OnEdgeMessage>(OnEdge);
        }
    }
}

