using Agate.MVC.Base;
using SpaceInvader.Gameplay.Bullet;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Gameplay.Bullet
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
            _model.CreateAudioObject();

        }

        public override void SetView(BulletView view)
        {
            base.SetView(view);
            view.SetCallbacks();
        }

        public void OnSpaceshipBulletFire(Vector3 positionTemp)
        {
            Spawn(positionTemp);
            _model.OnSpaceshipBulletFire(positionTemp);
            _model.sfx.Play();
        }


        private void Spawn(Vector3 position)
        {
            BulletView bulletPrefab = Resources.Load<BulletView>(@"Prefabs/Bullet");
            BulletView bulletView = GameObject.Instantiate<BulletView>(bulletPrefab);
            bulletView.SetPosition(position);

            SetView(bulletView);

            
        }

    }

}
