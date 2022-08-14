using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvander.Boot
{
        public abstract class SceneLauncher<TLauncher, TView> : BaseLauncher<TLauncher, TView>
         where TLauncher : SceneLauncher<TLauncher, TView>
         where TView : BaseSceneView
        { 
        public override string SceneName => "SplashScreen";

        protected override ILoad GetLoader()
        {
            return SceneLoader.Instance;
        }

        protected override IMain GetMain()
        {
            return GameMain.Instance;
        }

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }
        protected override IController[] GetSceneDependencies()
        {
            throw new System.NotImplementedException();
        }

        protected override ISplash GetSplash()
        {
            return SplashScreen.Instance;
        }

        protected override IEnumerator InitSceneObject()
        {
            throw new System.NotImplementedException();
        }

        protected override IEnumerator LaunchScene()
        {
            throw new System.NotImplementedException();
        }
    }

}
