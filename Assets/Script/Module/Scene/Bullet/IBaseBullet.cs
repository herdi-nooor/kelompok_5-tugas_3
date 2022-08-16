using Agate.MVC.Base;
using UnityEngine;

namespace SpaceInvader.Gameplay.Bullet
{
    public interface IBaseBullet :  IBaseModel
    {
        public Vector2 position { get; }

        public string Name { get; }

    }

}
