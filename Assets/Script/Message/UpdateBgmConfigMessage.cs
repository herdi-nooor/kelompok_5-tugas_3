using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Message
{
    public struct UpdateBgmConfigMessage
    {
        public bool IsBgmOn { get; private set; }
        public UpdateBgmConfigMessage(bool isBgmOn)
        {
            IsBgmOn = isBgmOn;
        }
    }
}
