using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvander.Boot;
using Agate.MVC.Core;
using SpaceInvander.Gameplay.Bullet;

namespace SpaceInvander.Gameplay
{
    public class GameplayLauncher : 
        SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";
        private BulletController _bullet;
        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] { new BulletController() };
        }

        protected override IEnumerator InitSceneObject()
        {
            _bullet.SetView(_view.bulletView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }

}
