using DG.Tweening;
using UnityEngine;

namespace ProtoPack.Tween
{
    [RequireComponent(typeof(RectTransform))]
    public class AnchorPosTween : TweenBase
    {
        [SerializeField] private RectTransform _rectTransform;
        [SerializeField] private AnchorPosTweenProperties _anchorPosTweenProperties;
        
        protected override Tweener CreateTweener()
        {
            var properties = _anchorPosTweenProperties;
            var tween = _rectTransform.DOAnchorPos(properties.EndValue, properties.Duration, properties.Snapping)
                .SetEase(properties.Ease);
            if (properties.Looping)
            {
                tween.SetLoops(properties.LoopCount, properties.LoopType);
            }
            _rectTransform.anchoredPosition = _anchorPosTweenProperties.StartPos ?? _rectTransform.anchoredPosition;
            return tween;
        }
    }
}