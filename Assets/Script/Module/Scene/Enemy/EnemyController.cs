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
            view.SetCallbacks(OnCollidedWithSpaceshipBullet, OnEnemyShoot, OnEdge, OnMove);
        }

        public void OnCollidedWithSpaceshipBullet()
        {
            Debug.Log("Destroyed!");
            _view.gameObject.SetActive(false);
            Publish(new AddScoreMessage());
            Publish(new EnemyDiedMessage());
        }

        public void OnEnemyShoot()
        {
            Debug.Log("Enemey fire!");
            Debug.Log(_model.position);
            Publish(new EnemyBulletMessage(_model.position));
        }

        public void OnRespawn()
        {
            _view.gameObject.SetActive(true);
        }

        public void OnEdge()
        {
            Publish(new OnEdgeMessage());
        }

        public void OnMove()
        {
            _model.SetPosition(_view.transform.position);
        }

        public void Init(EnemyModel model, EnemyView view)
        {
            _model = model;
            SetView(view);
        }
    }

}
