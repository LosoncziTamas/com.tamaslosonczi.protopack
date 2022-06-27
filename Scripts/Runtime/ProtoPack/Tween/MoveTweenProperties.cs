using ProtoPack.EditorUtility;
using UnityEngine;

namespace ProtoPack.Tween
{
    [CreateAssetMenu(menuName = "Proto Pack/Tweens/Move Tween Properties")]
    public class MoveTweenProperties : TweenProperties
    {
        public Vector3 EndValue => _endValue; 
        public Vector3? StartPos => _setStartPosition ? _startPosition : null; 
        public bool Snapping => _snapping;

        [SerializeField] private Vector3 _endValue;
        [SerializeField] private bool _snapping;
        [SerializeField] private bool _setStartPosition;
        
        [ShowIf(ActionOnConditionFail.DontDraw, ConditionOperator.And, nameof(_setStartPosition))]
        [SerializeField] private Vector3 _startPosition;
    }
}