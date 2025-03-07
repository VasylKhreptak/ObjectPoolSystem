using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Plugins.ObjectPoolSystem
{
    public interface IObjectPool
    {
        public int TotalCount { get; }
        public int ActiveCount { get; }
        public int InactiveCount { get; }
        
        public event Action<GameObject> OnEnabledObject;
        public event Action<GameObject> OnDisabledObject;
        public event Action<GameObject> OnDestroyedObject;
        public event Action OnCleared;

        public UniTask Initialize();
        
        public UniTask<GameObject> Get();

        public UniTask Expand();

        public UniTask Expand(int count);

        public void Clear();
    }
}