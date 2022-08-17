using Agate.MVC.Base;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Gameplay.Bullet
{
    public class BulletView : ObjectView<IBaseBullet>
    {

        [SerializeField] private BulletModel _shapePrefab;
        private UnityAction _OnMoveBullet;

        public void SetCallbacks(UnityAction OnMoveBullet)
        {
            _OnMoveBullet = OnMoveBullet;
        }

        private void Start()
        {
        }
        private void Update()
        {
            _OnMoveBullet?.Invoke();
        }

        protected override void InitRenderModel(IBaseBullet model)
        {
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

        private void Spawn()
        {

        }


    }

}
