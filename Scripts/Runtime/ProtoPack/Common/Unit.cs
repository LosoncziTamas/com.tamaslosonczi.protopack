using System;
using UnityEngine;

namespace ProtoPack.Common
{
    public abstract class Unit : MonoBehaviour
    {
        [SerializeField] protected UnitContainer _unitContainer;

        protected virtual void Awake()
        {
            _unitContainer.Add(this);
        }

        protected virtual void OnDestroy()
        {
            _unitContainer.Remove(this);
        }
    }
}
