using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Spaceship
{
    public class SpaceshipModel : BaseModel, ISpaceshipModel
    {
        public Vector3 position { get; private set; } = new Vector3(0f, -4f, 0f);

        public void SetPosition(Vector3 positionTemp)
        {
            position = positionTemp;
            SetDataAsDirty();
        }
    }

}
