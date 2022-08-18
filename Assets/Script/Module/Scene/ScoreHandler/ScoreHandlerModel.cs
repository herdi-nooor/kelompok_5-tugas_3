using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.ScoreHandler
{
    public class ScoreHandlerModel : BaseModel, IScoreHandlerModel
    {
        public int Score { get; private set; }

        public void SetScoreData(int score)
        {
            Score = score;
            SetDataAsDirty();
        }
    }
}

