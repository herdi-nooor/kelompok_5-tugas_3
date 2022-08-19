using Agate.MVC.Base;
using SpaceInvader.Gameplay.GameOver;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Gameplay.GameOver
{
    public class GameOverModel : BaseModel, IGameOverModel
    {
        public int score { get; private set; }


    }

}
