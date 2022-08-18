using Agate.MVC.Base;
using SpaceInvader.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, IEnemyModel, EnemyView>
    {
        public override void SetView(EnemyView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnMove, OnActivate, OnCollidedWithSpaceshipBullet, OnEnemyShoot, OnEdge);
        }

        public void OnMove()
        {
            //if (_model.isRight)
            //{
            //    Vector3 position = _model.position + (Vector3.right * Time.deltaTime);
            //    _model.SetPosition(position);
            //}
            //else
            //{
            //    Vector3 position = _model.position + (Vector3.left * Time.deltaTime);
            //    _model.SetPosition(position);
            //}    

        }

        public void OnActivate()
        {
            Debug.Log("Spawn!");
            Vector3 spawnPosition = _view.transform.position;
            _model.SetSpawnPosition(spawnPosition);
        }

        public void OnCollidedWithSpaceshipBullet()
        {
            Debug.Log("Destroyed!");
            Publish(new AddScoreMessage());
            Publish(new EnemyDiedMessage());
            _view.gameObject.SetActive(false);
        }

        public void OnEnemyShoot()
        {
            Debug.Log("Enemey fire!");
            Publish(new EnemyBulletMessage());
        }

        public void OnRespawn()
        {
            _view.gameObject.SetActive(true);
        }

        public void OnEdge()
        {
            Publish(new OnEdgeMessage());
        }

        public void Init(EnemyModel model, EnemyView view)
        {
            _model = model;
            SetView(view);
        }
    }

}
