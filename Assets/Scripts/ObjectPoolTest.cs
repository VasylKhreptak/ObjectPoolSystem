using System.Threading;
using Cysharp.Threading.Tasks;
using Plugins.ObjectPoolSystem;
using UnityEngine;

public class ObjectPoolTest : MonoBehaviour
{
    [Header("Preferences")]
    [SerializeField] private GameObject _prefab;

    private IObjectPool _objectPool;

    private void Awake() => _objectPool = new ObjectPool(token => InstantiateAsync(_prefab, token), 10, 100);

    private async UniTask<GameObject> InstantiateAsync(GameObject prefab, CancellationToken token = default)
    {
        AsyncInstantiateOperation<GameObject> instantiateOperation = Object.InstantiateAsync(prefab);

        await instantiateOperation;

        return instantiateOperation.Result[0];
    }
}