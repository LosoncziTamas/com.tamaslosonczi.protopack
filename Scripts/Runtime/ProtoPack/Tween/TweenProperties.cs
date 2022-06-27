using DG.Tweening;
using ProtoPack.EditorUtility;
using UnityEngine;

namespace ProtoPack.Tween
{
    [CreateAssetMenu(menuName = "Proto Pack/Tweens/Base Tween Properties")]
    public class TweenProperties : ScriptableObject
    {
        public float Duration => _duration;
        public Ease Ease => _ease;
        public int LoopCount => _loopCount;
        public bool Looping => _looping;
        public LoopType LoopType => _loopType;

        [SerializeField] private float _duration;
        [SerializeField] private Ease _ease = Ease.Linear;
        [SerializeField] private bool _looping = false;
        
        [ShowIf(ActionOnConditionFail.DontDraw, ConditionOperator.And, nameof(_looping))]
        [SerializeField] private int _loopCount = -1;
        
        [ShowIf(ActionOnConditionFail.DontDraw, ConditionOperator.And, nameof(_looping))]
        [SerializeField] private LoopType _loopType = LoopType.Yoyo;
    }
}