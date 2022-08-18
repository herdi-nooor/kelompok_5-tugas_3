using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyModel : BaseModel, IEnemyModel
    {
        //private float clampBorderOffset = 0.5f;
        public bool isRight = true;
        public Vector3 spawnPosition { get; private set; }
        public Vector3 position { get; private set; }
        private int i = 3;
        private int j = -2;

        public EnemyModel()
        {
            isRight = true;
            position = new Vector3(j, i, 0);
            j++;
            if (j > 2)
            {
                i--;
                if (i < 1)
                {
                    i = 3;
                    j = -2;
                }
            }
        }

        public void SetPosition(Vector3 positionTemp)
        {
            position = positionTemp;
            //float frustrumPositionRightX = Camera.main.ViewportToWorldPoint(new Vector2(1, 0)).x;
            //float frustrumPositionLeftX = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).x;
            //// Clamp left and right
            //if ((position.x > frustrumPositionRightX - clampBorderOffset) || (position.x < frustrumPositionLeftX + clampBorderOffset))
            //{
            //    isRight = !isRight;
            //    position = new Vector3(position.x, position.y - 0.1f, position.z);
            //}
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
