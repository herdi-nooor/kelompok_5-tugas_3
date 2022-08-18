using Agate.MVC.Base;
using SpaceInvader.Module.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.EnemyPool
{
    public class EnemyPoolModel : BaseModel, IEnemyPoolModel
    {
        public bool isRight = true;
        public Vector3 spawnPosition { get; private set; } = new Vector3(0f, 0f, 0f);
        public Vector3 position { get; private set; } = new Vector3(0f, 0f, 0f);
        public List<GameObject> EnemyPool = new List<GameObject>();
        public int spawnCount = 0;

        public void SetPosition(Vector3 positionTemp)
        {
            position = positionTemp;
            SetDataAsDirty();
        }

        public void OnEdge()
        {
            if (position.x > 0)
            {
                isRight = false;
            }
            else if (position.x < 0)
            {
                isRight = true;
            }
            position = new Vector3(position.x, position.y - 0.1f, position.z);
            SetDataAsDirty();
        }

        public void Despawned()
        {
            spawnCount--;
            SetDataAsDirty();
        }

        public void OnRespawned()
        {
            position = spawnPosition;
            spawnCount = 15;
            SetDataAsDirty();
        }

        public void EnqueueEnemy(GameObject enemy)
        {
            EnemyPool.Add(enemy);
            spawnCount++;
            Debug.Log(spawnCount);
            SetDataAsDirty();
        }
    }
}
