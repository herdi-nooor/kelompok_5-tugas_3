using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvander.Boot;
using Agate.MVC.Core;
using SpaceInvader.Module.Spaceship;

namespace SpaceInvander.Gameplay
{
    public class GameplayLauncher : 
        SceneLauncher<GameplayLauncher, GameplayView>
    {
        private SpaceshipController _spaceship;

        public override string SceneName => "Gameplay";
        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]{
                new SpaceshipController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _spaceship.SetView(_view.SpaceshipView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }

}
