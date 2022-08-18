using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceInvader.Module.UI
{
    public class UIController : ObjectController<UIController, UIModel, IUIModel, UIView>
    {
        public void OnScoreUpdate(int score)
        {
            _model.OnScoreUpdate(score);
        }

        public void OnLivesUpdate(int lives)
        {
            _model.OnLivesUpdate(lives);
        }
    }
}
