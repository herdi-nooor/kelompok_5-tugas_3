using Agate.MVC.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Gameplay.Bullet
{
    public class BulletEnemyView : ObjectView<IBaseBullet>
    {

        private UnityAction _OnMoveBulletEnemy;

        public void SetCallbacks(UnityAction OnMoveBulletEnemy)
        {
            _OnMoveBulletEnemy = OnMoveBulletEnemy;
        }

        /*private void Update()
        {
            _OnMoveBulletEnemy?.Invoke();
        }*/

        protected override void InitRenderModel(IBaseBullet model)
        {
            gameObject.SetActive(true);
            transform.position = _model.position;
        }
        protected override void UpdateRenderModel(IBaseBullet model)
        {
            transform.position = _model.position;
        }

        internal void SetCallbacks(object v)
        {
            throw new NotImplementedException();
        }
    }

}
