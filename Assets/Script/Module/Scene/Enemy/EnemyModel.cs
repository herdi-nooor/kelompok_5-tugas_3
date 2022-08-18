using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyModel : BaseModel, IEnemyModel
    {
        public bool isRight = true;
        public Vector3 spawnPosition { get; private set; }
        public Vector3 position { get; private set; }

        public EnemyModel()
        {

        }
    }

}
