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
        private UnityAction _onEnemyShoot;
        private float timer = 0;

        public void SetCallbacks(UnityAction onMove, UnityAction onActivate, UnityAction onCollidedWithSpaceshipBullet, UnityAction onEnemyShoot)
        {
            _onMove = onMove;
            _onActivate = onActivate;
            _onCollidedWithSpaceshipBullet = onCollidedWithSpaceshipBullet;
            _onEnemyShoot = onEnemyShoot;
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
            timer += Time.deltaTime;
            _onMove?.Invoke();
            if (timer >= 1.5f)
            {
                _onEnemyShoot?.Invoke();
                timer = 0;
            }
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
