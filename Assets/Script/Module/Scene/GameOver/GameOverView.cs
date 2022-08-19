using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SpaceInvader.Gameplay.GameOver
{
    public class GameOverView : ObjectView<IGameOverModel>
    {
        [SerializeField] private TextMeshProUGUI textPanel;

        protected override void InitRenderModel(IGameOverModel model)
        {
            throw new System.NotImplementedException();
        }

        protected override void UpdateRenderModel(IGameOverModel model)
        {
            throw new System.NotImplementedException();
        }

        private string GetdataPlayer()
        {
            string name = textPanel.GetComponent<TextMeshProUGUI>().text;
            
            return name;
        }
    }

}
