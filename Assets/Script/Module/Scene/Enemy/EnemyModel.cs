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
        public Vector3 spawnPosition { get; private set; } = new Vector3(0f, 3f, 0f);
        public Vector3 position { get; private set; } = new Vector3(0f, 3f, 0f);

        public void SetPosition(Vector3 positionTemp)
        {
            position = positionTemp;
            float frustrumPositionRightX = Camera.main.ViewportToWorldPoint(new Vector2(1, 0)).x;
            float frustrumPositionLeftX = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).x;
            // Clamp left and right
            if ((position.x > frustrumPositionRightX - clampBorderOffset) || (position.x < frustrumPositionLeftX + clampBorderOffset))
            {
                isRight = !isRight;
                position = new Vector3(position.x, position.y - 0.1f, position.z);
            }
            SetDataAsDirty();
        }

        public void SetSpawnPosition(Vector3 positionTemp)
        {
            spawnPosition = positionTemp;
            position = spawnPosition;
            SetDataAsDirty();
        }
    }

}
