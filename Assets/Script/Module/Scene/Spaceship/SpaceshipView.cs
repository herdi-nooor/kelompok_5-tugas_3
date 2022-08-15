using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Module.Spaceship
{
    public class SpaceshipView : ObjectView<ISpaceshipModel>
    {
        private UnityAction _onMoveLeft;
        private UnityAction _onMoveRight;

        public void SetCallbacks(UnityAction onMoveLeft, UnityAction onMoveRight)
        {
            _onMoveLeft = onMoveLeft;
            _onMoveRight = onMoveRight;
        }

        protected override void InitRenderModel(ISpaceshipModel model)
        {
            transform.position = _model.position;
        }

        protected override void UpdateRenderModel(ISpaceshipModel model)
        {
            transform.position = _model.position;
        }

        private void Update()
        {
            _onMoveLeft?.Invoke();
            _onMoveRight?.Invoke();
        }
    }

}
