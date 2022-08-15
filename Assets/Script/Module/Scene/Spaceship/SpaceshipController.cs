using Agate.MVC.Base;
using Agate.MVC.Core;
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
            view.SetCallbacks(OnMoveLeft, OnMoveRight);
        }

        private void OnMoveLeft()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Vector3 position = _model.position + (Vector3.left * Time.deltaTime);
                _model.SetPosition(position);
            }
        }

        private void OnMoveRight()
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Vector3 position = _model.position + (Vector3.right * Time.deltaTime);
                _model.SetPosition(position);
            }
        }
    }

}
