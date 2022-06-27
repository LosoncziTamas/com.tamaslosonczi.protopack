using UnityEngine;

namespace ProtoPack.Tween
{
    [CreateAssetMenu(menuName = "Proto Pack/Tweens/Shake Position Tween Properties")]
    public class ShakePositionTweenProperties : TweenProperties
    {
        [SerializeField] private float _strength = 1.0f;
        [SerializeField] private int _vibrato = 10;
        [SerializeField] private bool _fadeOut = true;
        [SerializeField] private bool _snapping;
        
        [Range(0, 180)] 
        [SerializeField] private float _randomness = 90;

        public float Strength => _strength;
        public int Vibrato => _vibrato;
        public bool FadeOut => _fadeOut;
        public bool Snapping => _snapping;
        public float Randomness => _randomness;
    }
}