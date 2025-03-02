using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Plugins.ObjectPoolSystem
{
    [Serializable]
    public class ObjectPoolPreference<T>
    {
        public T Key;
        public Func<UniTask<GameObject>> CreateFunc;
        public GameObject Prefab;
        public int InitialSize;
        public int MaxSize = 20;
    }
}