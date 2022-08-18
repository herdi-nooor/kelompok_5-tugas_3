using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.LivesHandler
{
    public interface ILivesHandlerModel : IBaseModel
    {
        public int Lives { get; }
    }

}
