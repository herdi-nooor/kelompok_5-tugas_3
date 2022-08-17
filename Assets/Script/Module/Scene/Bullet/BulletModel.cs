using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;

namespace SpaceInvader.Gameplay.Bullet
{

    public class BulletModel : BaseModel, IBaseBullet
    {
        public string Name { get; private set; }

        public Vector2 position { get; private set; } = new Vector2(0, 0);
        
        public void SetPosition(Vector2 positionTmp)
        {
            position = positionTmp;
            SetDataAsDirty();

        }
        
        public void OnSpaceshipBulletFire(Vector2 positionTemp)
        {
            position = positionTemp;
            SetDataAsDirty();
        }

        public void SetName(string name)
        {
            Name = name;
            SetDataAsDirty();
        }
    }
}
