using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Module.Spaceship
{
    public class SpaceshipView : ObjectView<ISpaceshipModel>
    {
        private UnityAction _onCollidedWithEnemyBullet;
        private UnityAction _onCollidedWithPowerUp;

        public void SetCallbacks(UnityAction onCollidedWithEnemyBullet, UnityAction onCollidedWithPowerUp)
        {
            _onCollidedWithEnemyBullet = onCollidedWithEnemyBullet;
            _onCollidedWithPowerUp = onCollidedWithPowerUp;
        }

        protected override void InitRenderModel(ISpaceshipModel model)
        {
            transform.position = _model.position;
        }

        protected override void UpdateRenderModel(ISpaceshipModel model)
        {
            transform.position = _model.position;
        }

        private void Update()
        {

        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("EnemyBullet"))
            {
                _onCollidedWithEnemyBullet?.Invoke();
            }
            else if (collision.gameObject.CompareTag("PowerUp"))
            {
                _onCollidedWithPowerUp?.Invoke();
            }
        }
    }

}
