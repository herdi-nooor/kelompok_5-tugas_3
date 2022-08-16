using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Menu.HighScore
{
    public class HighScoreDataModel : BaseModel, IHighScoreDataModel
    {
        public SortedDictionary<string, int> dataScore => new SortedDictionary<string, int>();

        public void Add(string name, int score)
        {
            if (name != null)
            {
                foreach (var i in dataScore)
                    // cek kalau score lebih besar dari
                    // list score yang sudah ada dalam _topscore
                    if (score > i.Value) dataScore.Add(name, score);
            }
            else
            {
                Debug.Log("input name null !!");
            }
        }


    }
}
