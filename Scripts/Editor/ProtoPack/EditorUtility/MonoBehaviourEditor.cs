#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace ProtoPack.EditorUtility
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(MonoBehaviour), true)]
    public class MonoBehaviourEditor : Editor
    {
    }
}
#endif