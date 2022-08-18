using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyView : ObjectView<IEnemyModel>
    {
        private UnityAction _onCollidedWithSpaceshipBullet;
        private UnityAction _onEnemyShoot;
        private UnityAction _onEdge;
        private float timer = 0;
        private float clampBorderOffset = 0.5f;

        public void SetCallbacks(UnityAction onCollidedWithSpaceshipBullet, UnityAction onEnemyShoot, UnityAction OnEdge)
        {
            _onCollidedWithSpaceshipBullet = onCollidedWithSpaceshipBullet;
            _onEnemyShoot = onEnemyShoot;
            _onEdge = OnEdge;
        }

        protected override void InitRenderModel(IEnemyModel model)
        {

        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {

        }

        private void Update()
        {
            timer += Time.deltaTime;
            OnEdge();
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

        public void OnEdge()
        {
            float frustrumPositionRightX = Camera.main.ViewportToWorldPoint(new Vector2(1, 0)).x;
            float frustrumPositionLeftX = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).x;
            // Clamp left and right
            if ((transform.position.x > frustrumPositionRightX - clampBorderOffset) || (transform.position.x < frustrumPositionLeftX + clampBorderOffset))
            {
                _onEdge?.Invoke();
            }
        }

        public void SetPosition(Vector3 position)
        {
            transform.position = position;
        }
    }

}
