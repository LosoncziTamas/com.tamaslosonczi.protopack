using UnityEngine;

namespace ProtoPack.Common
{
    public class Unit : MonoBehaviour
    {
        [SerializeField] protected UnitContainer _container;
        
        protected virtual void Awake()
        {
            _container.Add(this);
        }

        protected virtual void OnDestroy()
        {
            _container.Remove(this);
        }
    }
}
