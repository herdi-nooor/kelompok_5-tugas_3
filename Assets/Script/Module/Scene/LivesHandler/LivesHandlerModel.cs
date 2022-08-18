using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.LivesHandler
{
    public class LivesHandlerModel : BaseModel, ILivesHandlerModel
    {
        public int Lives { get; private set; } = 5;

        public void SetLivesData(int lives)
        {
            Lives = lives;
            SetDataAsDirty();
        }
    }

}
