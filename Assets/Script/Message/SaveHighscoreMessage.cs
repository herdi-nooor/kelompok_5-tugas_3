using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Message
{
    public struct SaveHighscoreMessage
    {
        public int Score { get; private set; }

        public SaveHighscoreMessage(int score)
        {
            Score = score;
        }
    }

}
