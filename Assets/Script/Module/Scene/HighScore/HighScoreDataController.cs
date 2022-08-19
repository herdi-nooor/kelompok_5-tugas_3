using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using SpaceInvader.Message;

namespace SpaceInvader.Menu.HighScore
{
    public class HighScoreDataController : DataController<HighScoreDataController, HighScoreDataModel>
    {
        public void SetDataScore(string name, int score)
        {
            _model.Add(name, score);
        }

        public List<string> OnLoadData()
        {

            List<string> keys = new List<string>(_model.dataScore.Keys);
            List<int> values = new List<int>(_model.dataScore.Values);
            return keys;
            //Publish(new HighScoreMessage());
        }

        public void SaveData(string name, int score)
        {
            _model.Add(name, score);
        }
        
    }

}
