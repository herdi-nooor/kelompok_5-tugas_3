using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Spaceship
{
    public class SpaceshipModel : BaseModel, ISpaceshipModel
    {
        private float clampBorderOffset = 0.5f;
        public Vector3 position { get; private set; } = new Vector3(0f, -4f, 0f);

        public void SetPosition(Vector3 positionTemp)
        {
            position = positionTemp;
            float frustrumPositionRightX = Camera.main.ViewportToWorldPoint(new Vector2(1, 0)).x;
            // Clamp right
            if (position.x > frustrumPositionRightX - clampBorderOffset)
            {
                position = new Vector2(frustrumPositionRightX - clampBorderOffset, position.y);
            }
            float frustrumPositionLeftX = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).x;
            // Clamp left
            if (position.x < frustrumPositionLeftX + clampBorderOffset)
            {
                position = new Vector2(frustrumPositionLeftX + clampBorderOffset, position.y);
            }
            SetDataAsDirty();
        }
    }

}
