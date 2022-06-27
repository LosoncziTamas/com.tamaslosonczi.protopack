using System.Collections.Generic;
using UnityEngine;

namespace ProtoPack.Common
{
    [CreateAssetMenu(menuName = "Proto Pack/Unit Container")]
    public class UnitContainer : ScriptableObject
    {
        private readonly List<Unit> _units = new();

        public void Add(Unit unit)
        {
            _units.Add(unit);
        }

        public bool Remove(Unit unit)
        {
            return _units.Remove(unit);
        }

        public List<Unit> GetUnitsWithTag(string tag)
        {
            var result = _units.FindAll(unit => unit.CompareTag(tag));
            return result;
        }
    }
}