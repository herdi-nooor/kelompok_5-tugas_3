using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SpaceInvader.Gameplay.GameOver
{
    public class GameOverView : ObjectView<IGameOverModel>
    {

        protected override void InitRenderModel(IGameOverModel model)
        {
            throw new System.NotImplementedException();
        }

        protected override void UpdateRenderModel(IGameOverModel model)
        {
            throw new System.NotImplementedException();
        }

        private void GetdataPlayer()
        {
            TextMeshProUGUI nametPrefab = Resources.Load<TextMeshProUGUI>(@"Prefabs/Bullet");
            string name = GetComponent<TextMeshProUGUI>().text;
            
        }
    }

}
