using System.Collections.Generic;
using UnityEngine;

namespace ProtoPack.Common
{ 
    public abstract class Container<T> : ScriptableObject
    {
        public List<T> Items { get; private set; } = new();

        public void Add(T unit)
        {
            if (!Items.Contains(unit))
            {
                Items.Add(unit);
            }
        }
        
        public bool Remove(T unit)
        {
            return Items.Remove(unit);
        }
    }
}