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

        }

        public override void SetView(BulletEnemyView view)
        {
            base.SetView(view);
            view.SetCallbacks();
        }
        public void OnEnemyBulletFire(Vector3 positionTemp)
        {
            Spawn(positionTemp);
            _model.OnEnemyBulletFire(positionTemp);
        }

        private void Spawn(Vector3 position)
        {
            BulletEnemyView bulletPrefab = Resources.Load<BulletEnemyView>(@"Prefabs/BulletEnemy");
            BulletEnemyView bulletView = GameObject.Instantiate<BulletEnemyView>(bulletPrefab);
            bulletView.SetPosition(position);

            SetView(bulletView);


        }


    }
    
}
