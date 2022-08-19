using Agate.MVC.Base;
using SpaceInvader.Gameplay.GameOver;
using SpaceInvader.Menu.HighScore;
using SpaceInvader.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Gameplay {
    public class MainMenuConnector : BaseConnector
    {
        private GameOverController _gameOver;

        public void SaveData(SaveDataMessage message)
        {
            _gameOver.SaveData(message.Name, message.Score);
        }

        protected override void Connect()
        {
            Subscribe<SaveDataMessage>(SaveData);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SaveDataMessage>(SaveData);
        }
    }

}

