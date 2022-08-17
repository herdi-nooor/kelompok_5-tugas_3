using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyModel : BaseModel, IEnemyModel
    {
        private float clampBorderOffset = 0.5f;
        public bool isRight = true;
        public Vector3 position { get; private set; }

        public void SetPosition(Vector3 positionTemp)
        {
            position = positionTemp;
            float frustrumPositionRightX = Camera.main.ViewportToWorldPoint(new Vector2(1, 0)).x;
            // Clamp right
            if (position.x > frustrumPositionRightX - clampBorderOffset)
            {
               isRight = false;
                position = new Vector3(position.x, position.y - 0.1f, position.z);
            }
            float frustrumPositionLeftX = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).x;
            // Clamp left
            if (position.x < frustrumPositionLeftX + clampBorderOffset)
            {
                isRight = true;
                position = new Vector3(position.x, position.y - 0.1f, position.z);
            }
            SetDataAsDirty();
        }
    }

}
