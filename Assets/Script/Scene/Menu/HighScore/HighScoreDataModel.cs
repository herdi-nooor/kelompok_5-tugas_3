using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvander.Menu.HighScore
{
    public class HighScoreDataModel : BaseModel, IHighScoreDataModel
    {
        public SortedDictionary<string, int> DataScore => new SortedDictionary<string, int>();
        private List<string> _topScore;

        private void Add(string name, int score)
        {
            if (name != null)
            {
                foreach (var i in DataScore)
                    // cek kalau score lebih besar dari
                    // list score yang sudah ada dalam _topscore
                    if (score > i.Value) DataScore.Add(name, score);
            }
            else
            {
                Debug.Log("input name null !!");
            }
        }
        public List<string> TopScore
        {
            get
            {
                return _topScore;
            }
            set
            {
                _topScore = value;
            }
        }
    }
}
