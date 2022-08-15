using Agate.MVC.Base;
using SpaceInvander.Gameplay.Bullet;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvander.Gameplay.Bullet
{
    public class BulletController : ObjectController<BulletController, 
        BulletModel, IBaseBullet, BulletView>
    {
        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
        }

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();

            GameObject bullet = new GameObject("Bullet");
            BulletView bulletView = bullet.AddComponent<BulletView>();
            SetView(bulletView);
        }

        public override void SetView(BulletView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnMoveBullet);
        }

        public void OnMoveBullet()
        {
            Vector2 position = _model.position + (Vector2.up * Time.deltaTime * 5);
            _model.SetPosition(position);
        }
        public void OnStartPlay(StartPlayMessage message)
        {
        }
    }

}
