using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Gameplay.GameOver
{
    public class GameOverController : ObjectController<GameOverController, GameOverModel, IGameOverModel, GameOverView>
    {
        public void GetScore(int score)
        {
            _model.GetScore(score);
        }

        public override void SetView(GameOverView view)
        {
            base.SetView(view);

        }

        public void SaveData(string name, int score)
        {
            Publish(new SaveDataMessage(_model.Name, _model.Score));
        }
    }

}
