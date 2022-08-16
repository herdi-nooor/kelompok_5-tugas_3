using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Menu.HighScore
{
    public interface IHighScoreDataModel : IBaseModel
    {
        public SortedDictionary<string, int> dataScore { get; }
    }

}
