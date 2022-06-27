using DG.Tweening;
using UnityEngine;

namespace ProtoPack.Tween
{
    public class ShakePositionTween : TweenBase
    {
        [SerializeField] private ShakePositionTweenProperties _shakePositionTweenProperties;

        protected override Tweener CreateTweener()
        {
            var properties = _shakePositionTweenProperties;
            var tween = transform.DOShakePosition(properties.Duration, properties.Strength, properties.Vibrato, properties.Randomness, properties.Snapping, properties.FadeOut)
                .SetEase(properties.Ease);
            if (properties.Looping)
            {
                tween.SetLoops(properties.LoopCount, properties.LoopType);
            }
            return tween;
        }
    }
}