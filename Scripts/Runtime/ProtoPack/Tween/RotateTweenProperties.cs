using DG.Tweening;
using ProtoPack.EditorUtility;
using UnityEngine;

namespace ProtoPack.Tween
{
    [CreateAssetMenu(menuName = "Proto Pack/Tweens/Rotate Tween Properties")]
    public class RotateTweenProperties : TweenProperties
    {
        public Vector3? StartRotation => _setStartRotation ? _startRotation : null;
        public Vector3 EndValue => _endValue;
        public RotateMode RotateMode => _rotateMode;

        [SerializeField] private Vector3 _endValue;
        [SerializeField] private RotateMode _rotateMode;
        [SerializeField] private bool _setStartRotation;
        
        [ShowIf(ActionOnConditionFail.DontDraw, ConditionOperator.And, nameof(_setStartRotation))]
        [SerializeField] private Vector3 _startRotation;

    }
}