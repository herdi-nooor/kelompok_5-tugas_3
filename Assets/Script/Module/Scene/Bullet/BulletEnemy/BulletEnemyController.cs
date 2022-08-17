using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Gameplay.Bullet
{
    public class BulletEnemyController : ObjectController<BulletEnemyController,
            BulletEnemyModel, IBaseBullet, BulletEnemyView>
    {
        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
        }

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();

            GameObject bullet = new GameObject("Bullet");
            BulletEnemyView bulletView = bullet.AddComponent<BulletEnemyView>();
            SetView(bulletView);
        }

        public override void SetView(BulletEnemyView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnMoveBulletEnemy);
        }


        // ngambil posisi dari object penembak
        //  OnMoveBullet(Vector2 Gunposition)
        public void OnMoveBulletEnemy()
        {
            //                     ini ganti GunPosition
            Vector2 position = _model.position + (Vector2.down * Time.deltaTime * 5);
            _model.SetPosition(position);

            //Publish(new MoveBulletEnemyMessage());
        }

    }
    
}
