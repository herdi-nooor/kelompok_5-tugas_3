using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Module.EnemyPool
{
    public class EnemyPoolView : ObjectView<IEnemyPoolModel>
    {
        private UnityAction _onMove;

        public void SetCallbacks(UnityAction onMove)
        {
            _onMove = onMove;
        }

        protected override void InitRenderModel(IEnemyPoolModel model)
        {
            transform.position = _model.position;
        }

        protected override void UpdateRenderModel(IEnemyPoolModel model)
        {
            transform.position = _model.position;
        }

        private void Update()
        {
            _onMove?.Invoke();
        }
    }

}

