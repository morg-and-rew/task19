using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] protected List<Transform> _containers;

    private int _capacity = 30;
    private float _objectProbability = 0.5f;

    private List<T> _pool = new List<T>();

    public void Create(T prefab)
    {
        for (int i = 0; i < _capacity; i++)
        {
            float randomValue = Random.value;

            if (randomValue < _objectProbability)
            {
                T obj = Instantiate(prefab);
                obj.gameObject.SetActive(false);
                _pool.Add(obj);
            }
        }
    }

    public IEnumerator UpdateDeactivateTimer(T obj, float deactivateTime)
    {
        yield return new WaitForSeconds(deactivateTime);

        obj.gameObject.SetActive(false);
    }

    protected bool TryGetObject(out T result)
    {
        result = _pool.FirstOrDefault(p => !p.gameObject.activeSelf);

        return result != null;
    }

    protected void SetObject(T prefab)
    {
        Transform spawnPoint = GetRandomContainer();

        if (spawnPoint != null)
        {
            prefab.transform.position = spawnPoint.position; 
            prefab.gameObject.SetActive(true);
        }
    }

    private Transform GetRandomContainer()
    {
        if (_containers == null || _containers.Count == 0)
        {
            return null;
        }

        return _containers[Random.Range(0, _containers.Count)];
    }

    public void ResetPool()
    {
        foreach (T item in _pool)
        {
            item.gameObject.SetActive(false);
        }
    }
}