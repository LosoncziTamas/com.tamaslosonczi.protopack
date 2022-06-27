using UnityEngine;

namespace ProtoPack.Tween
{
    [CreateAssetMenu(menuName = "Proto Pack/Tweens/Punch Scale Tween Properties")]
    public class PunchScaleTweenProperties : TweenProperties
    {
        [SerializeField] private Vector3 _punch;
        [SerializeField] private int _vibrato = 10;
        
        [Range(0, 1)]
        [SerializeField] private float _elasticity = 1.0f;

        public Vector3 Punch => _punch;
        public int Vibrato => _vibrato;
        public float Elasticity => _elasticity;
    }
}