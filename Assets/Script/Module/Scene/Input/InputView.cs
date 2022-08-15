using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Module.InputManager
{
    public class InputView : BaseView
    {
        private UnityAction _onMoveLeft;
        private UnityAction _onMoveRight;
        private UnityAction _onSpaceshipBullet;

        public void SetCallbacks(UnityAction onMoveLeft, UnityAction onMoveRight, UnityAction onSpaceshipBullet)
        {
            _onMoveLeft = onMoveLeft;
            _onMoveRight = onMoveRight;
            _onSpaceshipBullet = onSpaceshipBullet;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _onSpaceshipBullet?.Invoke();
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _onMoveLeft?.Invoke();
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                _onMoveRight?.Invoke();
            }
        }
    }
}
