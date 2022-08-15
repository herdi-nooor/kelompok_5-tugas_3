using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvander.Boot;
using Agate.MVC.Core;
using SpaceInvader.Module.Spaceship;
using SpaceInvader.Gameplay;
using SpaceInvader.Module.InputManager;

namespace SpaceInvander.Gameplay
{
    public class GameplayLauncher : 
        SceneLauncher<GameplayLauncher, GameplayView>
    {
        private SpaceshipController _spaceship;
        private InputController _input;

        public override string SceneName => "Gameplay";
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
                new InputController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
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
