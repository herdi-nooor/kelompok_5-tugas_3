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

            GameObject bullet = new GameObject("Bullet");
            BulletView bulletView = bullet.AddComponent<BulletView>();
            SetView(bulletView);
        }

        public override void SetView(BulletView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnMoveBullet);
        }


        // ngambil posisi dari object penembak dan jenisnya
        //      OnMoveBullet(Vector2 Gunposition, bool isEnemy)
        public void OnMoveBullet()
        {
            //if (nameObject == "Spaceship")
            //{
            //                     ini gsnti GunPosition
                Vector2 position = _model.position + (Vector2.up * Time.deltaTime * 5);
                _model.SetPosition(position);
            //}
            //else if (nameObject == "Enemy")
            //{
            //    Vector2 position = _model.position + (Vector2.up * Time.deltaTime * 5);
            //    _model.SetPosition(position);
            //}
            //Publish(new MoveBulletMessage());
        }

        public void OnSpaceshipBulletFire(Vector2 positionTemp)
        {
            _model.OnSpaceshipBulletFire(positionTemp);
        }
        

        //fungsi yang di panggil di connector
        /*public void OnStartPlay(StartPlayMessage message)
        {
        }*/
    }

}
