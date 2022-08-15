using Agate.MVC.Base;
using SpaceInvader.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.InputManager
{
    public class InputController : ObjectController<InputController, InputView>
    {
        public override void SetView(InputView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnMoveLeft, OnMoveRight, OnSpaceshipBullet);
        }

        private void OnMoveLeft()
        {
            Publish(new MoveLeftMessage());
        }

        private void OnMoveRight()
        {
            Publish(new MoveRightMessage());
        }

        private void OnSpaceshipBullet()
        {
            Publish(new FireMessage());
        }
    }

}
