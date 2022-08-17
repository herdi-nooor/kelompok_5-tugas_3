using Agate.MVC.Base;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Pool;

namespace SpaceInvader.Gameplay.Bullet
{
    public class BulletView : ObjectView<IBaseBullet>
    {

        [SerializeField] private BulletModel _shapePrefab;
        private UnityAction _OnMoveBullet;
        private ObjectPool<BulletModel> _pool;

        public void SetCallbacks(UnityAction OnMoveBullet)
        {
            _OnMoveBullet = OnMoveBullet;
        }

        private void Start()
        {
            _pool = new ObjectPool<BulletModel>(() =>
            {
                return Instantiate(_shapePrefab);
            }, shape =>
            {
                shape.gameObject.SetActive(true);
            }, shape =>
            {
                shape.gameObject.SetActive(false);
            }, shape =>
            {
                Destroy(shape.gameObject);
            }, false, 3, 10);
            InvokeRepeating(nameof(Spawn), 0.2f, 0.2f);
        }
        private void Update()
        {
            _OnMoveBullet?.Invoke();
        }

        protected override void InitRenderModel(IBaseBullet model)
        {
            gameObject.SetActive(true);
            transform.position = _model.position;
        }
        protected override void UpdateRenderModel(IBaseBullet model)
        {
            transform.position = _model.position;
        }

        internal void SetCallbacks(object v)
        {
            throw new NotImplementedException();
        }

        private void Spawn()
        {

        }


    }

}
