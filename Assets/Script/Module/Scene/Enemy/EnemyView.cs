using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyView : ObjectView<IEnemyModel>
    {
        private UnityAction _onMove;
        private UnityAction _onActivate;
        private UnityAction _onCollidedWithSpaceshipBullet;

        public void SetCallbacks(UnityAction onMove, UnityAction onActivate, UnityAction onCollidedWithSpaceshipBullet)
        {
            _onMove = onMove;
            _onActivate = onActivate;
            _onCollidedWithSpaceshipBullet = onCollidedWithSpaceshipBullet;
        }

        protected override void InitRenderModel(IEnemyModel model)
        {
            transform.position = _model.spawnPosition;
        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {
            transform.position = _model.position;
        }

        private void OnEnable()
        {
            _onActivate?.Invoke();
        }

        private void Update()
        {
            _onMove?.Invoke();
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("SpaceshipBullet"))
            {
                _onCollidedWithSpaceshipBullet?.Invoke();
            }
        }
    }

}
