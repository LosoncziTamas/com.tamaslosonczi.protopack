using ProtoPack.EditorUtility;
using UnityEngine;

namespace ProtoPack.Tween
{
    
    [CreateAssetMenu(menuName = "Proto Pack/Tweens/Anchor Pos Tween Properties")]
    public class AnchorPosTweenProperties : TweenProperties
    {
        public Vector2? StartPos => _setStartPosition ? _startPosition : null;
        public Vector2 EndValue => _endValue;
        public bool Snapping => _snapping;

        [SerializeField] private Vector2 _endValue;
        [SerializeField] private bool _snapping;
        [SerializeField] private bool _setStartPosition;
        
        [ShowIf(ActionOnConditionFail.DontDraw, ConditionOperator.And, nameof(_setStartPosition))]
        [SerializeField] private Vector2 _startPosition;
    }
}