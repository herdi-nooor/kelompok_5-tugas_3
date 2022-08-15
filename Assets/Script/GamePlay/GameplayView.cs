using Agate.MVC.Base;
using SpaceInvader.Module.Spaceship;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvander.Gameplay 
{ 
    public class GameplayView : BaseSceneView
    {
        [SerializeField] public SpaceshipView SpaceshipView;
    }

}

