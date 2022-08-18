using Agate.MVC.Base;
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
        }
    }
}
