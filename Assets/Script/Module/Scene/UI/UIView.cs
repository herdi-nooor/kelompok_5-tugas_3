using Agate.MVC.Base;
using SpaceInvader.Module.LivesHandler;
using SpaceInvader.Module.ScoreHandler;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SpaceInvader.Module.UI
{
    public class UIView : ObjectView<IUIModel>
    {
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private TextMeshProUGUI _livesText;

        protected override void InitRenderModel(IUIModel model)
        {
            _scoreText.text = _model.Score.ToString();
            _livesText.text = _model.Lives.ToString();
        }

        protected override void UpdateRenderModel(IUIModel model)
        {
            _scoreText.text = _model.Score.ToString();
            _livesText.text = _model.Lives.ToString();
        }
    }

}
