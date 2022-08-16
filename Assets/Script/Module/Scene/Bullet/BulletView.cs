using Agate.MVC.Base;
using System;
/*using SpaceInvander.Gameplay.Bullet;
using System.Collections;
using System.Collections.Generic;*/
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Gameplay.Bullet
{
    public class BulletView : ObjectView<IBaseBullet>
    {

        private UnityAction _OnMoveBullet;

        public void SetCallbacks(UnityAction OnMoveBullet)
        {
            _OnMoveBullet = OnMoveBullet;
        }

        private void Update()
        {
            _OnMoveBullet?.Invoke();
        }

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
