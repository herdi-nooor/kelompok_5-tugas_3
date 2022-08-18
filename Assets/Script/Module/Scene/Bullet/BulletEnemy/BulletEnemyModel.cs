using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Gameplay.Bullet
{
    public class BulletEnemyModel : BaseModel, IBaseBullet
    {
        public string Name { get; private set; }

        public Vector3 position { get; private set; } = new Vector3(0, 0);
        public Vector3 positionInit { get; set; } = new Vector3(0, 0);

        public void SetPosition(Vector2 positionTmp)
        {
            position = positionTmp;
            SetDataAsDirty();

        }
        public void SetName(string name)
        {
            Name = name;
            SetDataAsDirty();
        }
    }

}
