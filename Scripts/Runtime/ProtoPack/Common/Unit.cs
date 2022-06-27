using UnityEngine;

namespace ProtoPack.Common
{
    public abstract class Unit : MonoBehaviour
    {
        [SerializeField] private UnitContainer _unitContainer;

        private void Awake()
        {
            _unitContainer.Add(this);
        }

        private void OnDestroy()
        {
            _unitContainer.Remove(this);
        }
    }
}
