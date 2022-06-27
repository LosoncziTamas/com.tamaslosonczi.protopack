using DG.Tweening;
using UnityEngine;

namespace ProtoPack.Tween
{
    public abstract class TweenBase : MonoBehaviour
    {
        protected Tweener Tweener;
        
        [SerializeField] private bool _debug;
        [SerializeField] private bool _autoStart;

        protected virtual void Start()
        {
            if (_autoStart)
            {
                GetTweener().Play();
            }
        }

        public Tweener GetTweener()
        {
            return Tweener ??= CreateTweener();
        }
        
        protected abstract Tweener CreateTweener();
        
        private void OnGUI()
        {
            if (!_debug)
            {
                return;
            }
            GUILayout.FlexibleSpace();
            if (GUILayout.Button($"{gameObject.name} Tween Refresh"))
            {
                Tweener?.Kill();
                Tweener = CreateTweener();
            }
        }
    }
}