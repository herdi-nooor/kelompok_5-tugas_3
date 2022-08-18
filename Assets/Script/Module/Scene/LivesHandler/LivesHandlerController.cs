using Agate.MVC.Base;
using SpaceInvader.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.LivesHandler
{
    public class LivesHandlerController : DataController<LivesHandlerController, LivesHandlerModel>
    {
        public void OnSpaceshipHit()
        {
            int lives = _model.Lives - 1;
            _model.SetLivesData(lives);
            Publish(new UpdateLivesMessage(_model.Lives));
            Debug.Log("Lives remaining " + _model.Lives.ToString());
            if (_model.Lives <= 0)
            {
                Publish(new GameOverMessage());
                Debug.Log("Game Over!");
            }
        }
    }

}
