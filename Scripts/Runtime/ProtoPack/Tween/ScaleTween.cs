using DG.Tweening;
using UnityEngine;

namespace ProtoPack.Tween
{
    public class ScaleTween : TweenBase
    {
        [SerializeField] private ScaleTweenProperties _scaleTweenProperties;

        protected override Tweener CreateTweener()
        {
            transform.localScale = _scaleTweenProperties.StartScale ?? transform.localScale; 
            var properties = _scaleTweenProperties;
            var tween = transform.DOScale(properties.Scale, properties.Duration)
                .SetEase(properties.Ease);
            if (properties.Looping)
            {
                tween.SetLoops(properties.LoopCount, properties.LoopType);
            }

            return tween;
        }
    }
}