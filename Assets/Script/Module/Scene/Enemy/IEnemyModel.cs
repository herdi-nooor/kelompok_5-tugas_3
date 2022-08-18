using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Enemy
{
    public interface IEnemyModel : IBaseModel
    {
        public Vector3 position { get; }
        public Vector3 spawnPosition { get; }
    }

}
