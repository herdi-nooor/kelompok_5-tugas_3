using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Spaceship
{
    public class SpaceshipController : ObjectController<SpaceshipController, SpaceshipModel, ISpaceshipModel, SpaceshipView>
    {
        public override void SetView(SpaceshipView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnCollidedWithEnemyBullet, OnCollidedWithPowerUp);
        }

        public void OnMoveLeft()
        {
            Vector3 position = _model.position + (Vector3.left * Time.deltaTime);
            _model.SetPosition(position);
        }

        public void OnMoveRight()
        {
            Vector3 position = _model.position + (Vector3.right * Time.deltaTime);
            _model.SetPosition(position);
        }

        public void OnSpaceshipBullet()
        {
            Debug.Log("BANG!");
            Publish(new SpaceshipBulletMessage());
        }

        private void OnCollidedWithEnemyBullet()
        {
            Debug.Log("Ouch!");
            Publish(new LoseLivesMessage());
        }

        private void OnCollidedWithPowerUp()
        {
            Debug.Log("Super Power!");
            Publish(new PowerUpActivateMessage());
        }
    }

}
