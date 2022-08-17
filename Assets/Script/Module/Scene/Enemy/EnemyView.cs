using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyView : ObjectView<IEnemyModel>
    {
        private UnityAction _onMove;

        public void SetCallbacks(UnityAction onMove)
        {
            _onMove = onMove;
        }
        protected override void InitRenderModel(IEnemyModel model)
        {
            transform.position = _model.position;
        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {
            transform.position = _model.position;
        }

        private void Update()
        {
            _onMove?.Invoke();
        }
    }

}
