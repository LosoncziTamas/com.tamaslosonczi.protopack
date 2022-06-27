using ProtoPack.EditorUtility;
using UnityEngine;

namespace ProtoPack.Tween
{
    [CreateAssetMenu(menuName = "Proto Pack/Tweens/Scale Tween Properties")]
    public class ScaleTweenProperties : TweenProperties
    {
        public Vector3 Scale => _scale;
        public Vector3? StartScale => _setStartScale ? _startScale : null;
    
        [SerializeField] private Vector3 _scale = Vector3.one;
        [SerializeField] private bool _setStartScale;
        
        [ShowIf(ActionOnConditionFail.DontDraw, ConditionOperator.And, nameof(_setStartScale))]
        [SerializeField] private Vector3 _startScale;
    }
}