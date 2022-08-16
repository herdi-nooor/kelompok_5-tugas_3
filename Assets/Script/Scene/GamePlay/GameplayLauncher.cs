using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvader.Boot;
using Agate.MVC.Core;
using SpaceInvader.Gameplay.Bullet;
using SpaceInvader.Module.Spaceship;
using SpaceInvader.Gameplay;
using SpaceInvader.Module.InputManager;

namespace SpaceInvader.Gameplay
{
    public class GameplayLauncher : 
        SceneLauncher<GameplayLauncher, GameplayView>
    {
        private SpaceshipController _spaceship;
        private InputController _input;

        public override string SceneName => "Gameplay";
        private BulletController _bullet;
        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]{
                new GameplayConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]{
                new SpaceshipController(),
                new InputController(),
                new BulletController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _bullet.SetView(_view.bulletView);
            _spaceship.SetView(_view.SpaceshipView);
            _input.SetView(_view.InputView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }

}
