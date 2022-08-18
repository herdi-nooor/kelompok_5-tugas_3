using Agate.MVC.Base;
using SpaceInvader.Gameplay.Bullet;
using SpaceInvader.Module.Enemy;
using SpaceInvader.Module.EnemyPool;
using SpaceInvader.Module.InputManager;
using SpaceInvader.Module.Spaceship;
using SpaceInvader.Module.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Gameplay 
{ 
    public class GameplayView : BaseSceneView
    {
        [SerializeField] public BulletView bulletView;
        [SerializeField] public BulletEnemyView bulletEnemyView;
        [SerializeField] public SpaceshipView SpaceshipView;
        [SerializeField] public InputView InputView;
        [SerializeField] public UIView UIView;
        [SerializeField] public EnemyPoolView EnemyPoolView;
    }

}

