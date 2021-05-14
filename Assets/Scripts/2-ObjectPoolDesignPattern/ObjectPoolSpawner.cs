using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ObjectPool
{
    public class ObjectPoolSpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnInterval = 1f;
        private ObjectPoolDesignPattern _objectPool;

        private void Awake()
        {
            _objectPool = GetComponent<ObjectPoolDesignPattern>();
        }

        private void Start()
        {
            StartCoroutine(nameof(SpawnRoutine));
        }

        private IEnumerator SpawnRoutine()
        {
            while (true)
            {
                var poolObject=_objectPool.GetPoolObject(GetRandomPosition(0, _objectPool.GetPoolLengthOfType()));
                poolObject.transform.position = new Vector3(GetRandomPosition(0,10), 0, GetRandomPosition(0, 10));
                yield return new WaitForSeconds(_spawnInterval);
            }
        }

        private int GetRandomPosition(int value1,int value2)
        {
            return Random.Range(value1, value2);
        }
    }

}