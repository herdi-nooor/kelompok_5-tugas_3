using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.UI
{
    public interface IUIModel : IBaseModel
    {
        public int Lives { get; }
        public int Score { get; }
    }

}
