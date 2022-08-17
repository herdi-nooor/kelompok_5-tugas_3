using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, IEnemyModel, EnemyView>
    {
        public override void SetView(EnemyView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnMove);
        }

        public void OnMove()
        {
            if (_model.isRight)
            {
                Vector3 position = _model.position + (Vector3.right * Time.deltaTime);
                _model.SetPosition(position);
            }
            else
            {
                Vector3 position = _model.position + (Vector3.left * Time.deltaTime);
                _model.SetPosition(position);
            }    

        }
    }

}
