using System.Threading.Tasks;
using DG.Tweening;
using ProtoPack.Tween;
using UnityEngine;

namespace ProtoPack.Gui
{
    public class ModalBase<TResult> : MonoBehaviour
    {
        [SerializeField] protected TweenBase ShowTween;
        [SerializeField] protected TweenBase HideTween;
        
        private TaskCompletionSource<TResult> _taskCompletionSource;
        private Tweener _showTweener;

        protected virtual void Awake()
        {
            _showTweener = ShowTween.GetTweener();
            _showTweener.SetAutoKill(false);
            // Set to initial position
            _showTweener.Pause();
        }

        protected virtual Task<TResult> Show()
        {
            if (_showTweener.playedOnce)
            {
                _showTweener.Restart();
            }
            _showTweener.Play();
            _taskCompletionSource = new TaskCompletionSource<TResult>();
            return _taskCompletionSource.Task;
        }

        protected void SetResultAndHide(TResult result)
        {
            var hideTween = HideTween.GetTweener();
            if (hideTween.playedOnce)
            {
                hideTween.Restart();
            }
            hideTween.SetAutoKill(false);
            hideTween.OnComplete(() =>
            {
                _taskCompletionSource.SetResult(result);
            });
        }

        protected virtual void OnDestroy()
        {
            _showTweener.Kill();
            HideTween.GetTweener().Kill();
        }
    }
}