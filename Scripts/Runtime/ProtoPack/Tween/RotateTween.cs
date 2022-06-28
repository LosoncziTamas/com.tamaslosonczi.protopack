using DG.Tweening;
using UnityEngine;

namespace ProtoPack.Tween
{
    public class RotateTween : TweenBase
    {
        [SerializeField] private RotateTweenProperties _rotateTweenProperties;

        protected override Tweener CreateTweener()
        {
            var properties = _rotateTweenProperties;
            var tween = transform.DORotate(properties.EndValue, properties.Duration, properties.RotateMode)
                .SetEase(properties.Ease);
            if (properties.Looping)
            {
                tween.SetLoops(properties.LoopCount, properties.LoopType);
            }
            gameObject.transform.rotation = properties.StartRotation != null ? Quaternion.Euler(properties.StartRotation.Value) : transform.rotation;
            return tween;
        }
    }
}