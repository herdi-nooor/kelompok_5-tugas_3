using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Message
{
    public struct UpdateLivesMessage
    {
        public int Lives { get; private set; }

        public UpdateLivesMessage(int lives)
        {
            Lives = lives;
        }
    }

}
