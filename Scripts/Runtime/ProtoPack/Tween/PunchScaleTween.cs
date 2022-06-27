using DG.Tweening;
using UnityEngine;

namespace ProtoPack.Tween
{
    public class PunchScaleTween : TweenBase
    {
        [SerializeField] private PunchScaleTweenProperties _punchScaleTweenProperties;

        protected override Tweener CreateTweener()
        {
            var properties = _punchScaleTweenProperties;
            var tween = transform.DOPunchScale(properties.Punch, properties.Duration, properties.Vibrato, properties.Elasticity)
                .SetEase(properties.Ease);
            if (properties.Looping)
            {
                tween.SetLoops(properties.LoopCount, properties.LoopType);
            }
            return tween;
        }
    }
}