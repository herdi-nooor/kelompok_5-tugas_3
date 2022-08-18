using Agate.MVC.Base;
using SpaceInvader.Message;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.GameAudio
{
    public class GameAudioController : BaseController<GameAudioController>
    {
        private AudioSource _bgm;
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            CreateBgmObject();
        }

        public void OnUpdateBgmConfig(UpdateBgmConfigMessage message)
        {
            _bgm.mute = !message.IsBgmOn;
        }

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
        }


        private void CreateBgmObject()
        {
            GameObject bgmPrefabs = Resources.Load<GameObject>(@"Audio/bgm");
            GameObject bgmObject = GameObject.Instantiate(bgmPrefabs);
            GameObject.DontDestroyOnLoad(bgmObject);
            _bgm = bgmObject.GetComponent<AudioSource>();
        }
    }

}
