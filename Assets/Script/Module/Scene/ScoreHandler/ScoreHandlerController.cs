using Agate.MVC.Base;
using SpaceInvader.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceInvader.Module.ScoreHandler
{
    public class ScoreHandlerController : DataController<ScoreHandlerController, ScoreHandlerModel>
    {
        public void OnEnemyDestroyed()
        {
            int score = _model.Score + 10;
            _model.SetScoreData(score);
            Publish(new UpdateScoreMessage(_model.Score));
            Debug.Log("Scored " + _model.Score.ToString());
        }

        public void OnGameOver()
        {
            Publish(new SaveHighscoreMessage(_model.Score));
        }
    }

}
