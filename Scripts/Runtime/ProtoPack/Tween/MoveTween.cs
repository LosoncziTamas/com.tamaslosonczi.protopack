using DG.Tweening;
using UnityEngine;

namespace ProtoPack.Tween
{
    public class MoveTween : TweenBase
    {
        [SerializeField] private MoveTweenProperties _moveTweenProperties;

        protected override Tweener CreateTweener()
        {
            var properties = _moveTweenProperties;
            var tween = transform.DOMove(properties.EndValue, properties.Duration, properties.Snapping)
                .SetEase(properties.Ease);
            if (properties.Looping)
            {
                tween.SetLoops(properties.LoopCount, properties.LoopType);
            }
            gameObject.transform.position = _moveTweenProperties.StartPos ?? transform.position;;
            return tween;
        }
    }
}