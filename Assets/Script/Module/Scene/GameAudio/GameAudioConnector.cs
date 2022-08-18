using Agate.MVC.Base;
using SpaceInvader.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.GameAudio
{
    public class GameAudioConnector : BaseConnector
    {
        GameAudioController _gameAudio;
        protected override void Connect()
        {
            Subscribe<UpdateBgmConfigMessage>(_gameAudio.OnUpdateBgmConfig);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateBgmConfigMessage>(_gameAudio.OnUpdateBgmConfig);
        }
    }

}
