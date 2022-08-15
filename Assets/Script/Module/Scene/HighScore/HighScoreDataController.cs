using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using SpaceInvader.Message;

namespace SpaceInvander.Menu.HighScore
{
    public class HighScoreDataController : DataController<HighScoreDataController, HighScoreDataModel>
    {
        public void SetDataScore(string name, int score)
        {
            _model.Add(name, score);
        }

        public List<string> OnLoadData()
        {
            return _model.TopScore;
            Publish(new HighScoreMessage());
        }
        
    }

}
