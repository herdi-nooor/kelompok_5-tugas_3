using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceInvader.Gameplay.GameOver
{
    public class GameOverView : ObjectView<IGameOverModel>
    {
        [SerializeField] private TextMeshProUGUI _scoreTxt;
        [SerializeField] private TMP_InputField _nameInput;
        [SerializeField] private Button btn; 
        private string _name;
        protected override void InitRenderModel(IGameOverModel model)
        {
            throw new System.NotImplementedException();
        }

        protected override void UpdateRenderModel(IGameOverModel model)
        {
            throw new System.NotImplementedException();
        }

        private void Start()
        {
            _nameInput = GetComponent<TMP_InputField>();
        }
        private void Update()
        {
            btn.onClick.AddListener(GetdataPlayer);
            
        }

        private void GetdataPlayer()
        {
            _name = _nameInput.text;
            Debug.Log(_name);
        }


    }

}
