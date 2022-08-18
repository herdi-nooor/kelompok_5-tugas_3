using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Menu
{
    public class MenuLauncher : SceneLauncher<MenuLauncher, MenuView>
    {
        public override string SceneName => "MainMenu";

        private void OnClickPlayButton()
        {
            SceneLoader.Instance.LoadScene("Gameplay");
        }
        protected override IConnector[] GetSceneConnectors()
        {

            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            _view.SetCallbacks(OnClickPlayButton);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }

}
