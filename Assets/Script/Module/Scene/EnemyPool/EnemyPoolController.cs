using Agate.MVC.Base;
using SpaceInvader.Module.Enemy;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.EnemyPool
{
    public class EnemyPoolController : ObjectController<EnemyPoolController, EnemyPoolModel, IEnemyPoolModel, EnemyPoolView>
    {
        [SerializeField] private EnemyView _EnemyObjectPrefab; 
        
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            _EnemyObjectPrefab = Resources.Load<EnemyView>(@"Prefabs/ExampleObject");
        }

        public override void SetView(EnemyPoolView view)
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

        public void OnEdge()
        {
            _model.OnEdge();
        }

        public void CreateEnemyObject()
        {
            EnemyModel instanceModel = new EnemyModel();
            EnemyView instanceObject = GameObject.Instantiate(_EnemyObjectPrefab);
            EnemyView instanceView = instanceObject.GetComponent<EnemyView>();
            EnemyController instance = new EnemyController();
            InjectDependencies(instance);
            instance.Init(instanceModel, instanceView);
        }
    }

}

