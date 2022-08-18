using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.EnemyPool
{
    public interface IEnemyPoolModel : IBaseModel
    {
        public Vector3 position { get; }
        public Vector3 spawnPosition { get; }
    }

}

