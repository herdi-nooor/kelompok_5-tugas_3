using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.ScoreHandler
{
    public interface IScoreHandlerModel : IBaseModel
    {
        public int Score { get; }
    }
}

