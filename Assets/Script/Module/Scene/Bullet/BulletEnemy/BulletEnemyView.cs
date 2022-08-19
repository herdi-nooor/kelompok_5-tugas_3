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
        public void OnEdge()
        {
            float frustrumPositionUp = Camera.main.ViewportToWorldPoint(new Vector2(0, 1)).y;
            float frustrumPositiondown = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).y;

            if ((transform.position.y > frustrumPositionUp) || (transform.position.y < frustrumPositiondown))
            {
                DestroyBullet(gameObject);
            }
        }

        public void SetCallbacks()
        {
        }

        private void Update()
        {
            Vector3 position = transform.position + (Vector3.down * Time.deltaTime * 5f);
            SetPosition(position);
            OnEdge();
        }

        protected override void InitRenderModel(IBaseBullet model)
        {
        }
        protected override void UpdateRenderModel(IBaseBullet model)
        {
        }

        public void SetPosition(Vector3 position)
        {
            transform.position = position;
        }

        private void DestroyBullet(GameObject bullet)
        {
            Destroy(bullet);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log(collision);
            if (collision.gameObject.tag == "SpaceShip")
            {
                DestroyBullet(gameObject);
            }

        }
    }

}
