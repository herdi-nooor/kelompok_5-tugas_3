using Agate.MVC.Base;
using SpaceInvader.Message;
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
            _EnemyObjectPrefab = Resources.Load<EnemyView>(@"Prefabs/Enemy");
        }

        public override void SetView(EnemyPoolView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnMove);
            InitPoolObject();
        }

        public void InitPoolObject()
        {
            for (int i = 1; i < 4; i++)
            {
                for (int j = -2; j < 3; j++)
                {
                    CreateEnemyObject(i, j);
                }
            }
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

        public void CreateEnemyObject(int i, int j)
        {
            EnemyModel instanceModel = new EnemyModel();
            EnemyView instanceObject = GameObject.Instantiate(_EnemyObjectPrefab, _view.spawnArea);
            EnemyView instanceView = instanceObject.GetComponent<EnemyView>();
            EnemyController instance = new EnemyController();
            InjectDependencies(instance);
            instance.Init(instanceModel, instanceView);
            instanceView.SetPosition(new Vector3(j, i, 0));
        }

        public void OnEnemyDied()
        {
            _model.Despawned();
            if (_model.spawnCount == 0)
            {
                _model.OnRespawned();
                Respawned();
            }
        }

        public void Respawned()
        {
            Publish(new OnRespawnMessage());
        }
    }

}

