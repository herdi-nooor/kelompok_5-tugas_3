using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Spaceship
{
    public interface ISpaceshipModel : IBaseModel
    {
        public Vector3 position { get; }
    }
}
