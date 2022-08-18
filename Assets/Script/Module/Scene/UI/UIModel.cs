using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.UI
{
    public class UIModel : BaseModel, IUIModel
    {
        public int Lives { get; private set; } = 5;
        public int Score { get; private set; } = 0;

        public void OnScoreUpdate(int score)
        {
            Score = score;
            SetDataAsDirty();
        }

        public void OnLivesUpdate(int lives)
        {
            Lives = lives;
            SetDataAsDirty();
        }
    }

}
