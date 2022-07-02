using UnityEngine;

namespace ProtoPack.Common
{
    public abstract class Unit : MonoBehaviour
    {
        [SerializeField] protected UnitContainer _unitContainer;
        [SerializeField] protected Enumeration _enumeration;

        public abstract Enumeration Enumeration { get; }

        protected virtual void Awake()
        {
            _enumeration = Enumeration;
            _unitContainer.Add(this);
        }

        protected virtual void OnDestroy()
        {
            _unitContainer.Remove(this);
        }
    }
}
