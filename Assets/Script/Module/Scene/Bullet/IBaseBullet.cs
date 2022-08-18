using Agate.MVC.Base;
using UnityEngine;

namespace SpaceInvader.Gameplay.Bullet
{
    public interface IBaseBullet :  IBaseModel
    {
        public Vector3 position { get; }

        public string Name { get; }
        public Vector3 positionInit { get; set; }
    }

}
