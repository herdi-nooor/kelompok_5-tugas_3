using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Message
{
    public struct SaveDataMessage
    {
        public string Name { get; private set; }
        public int Score { get; private set; }

        public SaveDataMessage(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }

}
