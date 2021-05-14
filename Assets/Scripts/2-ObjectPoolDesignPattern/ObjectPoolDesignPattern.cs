using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ObjectPool
{
    public class ObjectPoolDesignPattern : MonoBehaviour
    {
        [Serializable] public struct Pool
        {
            public int poolSize;
            public GameObject poolObject;
            public Queue<GameObject> poolList;
        }
        [SerializeField] private Pool[] _pool=null;
        //[SerializeField] private int _poolSize;
        //[SerializeField] private GameObject _poolObject;
        //private Queue<GameObject> _poolList;

        private void Awake()
        {
            for (int i1 = 0; i1  < _pool.Length; i1++)
            {
                _pool[i1].poolList = new Queue<GameObject>();

                for (int i2 = 0; i2 < _pool[i1].poolSize; i2++)
                {
                    GameObject gameObject = Instantiate(_pool[i1].poolObject);
                    gameObject.name = _pool[i1].poolObject.name + (i2 + 1).ToString();
                    gameObject.SetActive(false);
                    _pool[i1].poolList.Enqueue(gameObject);
                }
            }
        }

        public GameObject GetPoolObject(int objectType)
        {
            if (objectType>=_pool.Length || objectType<0)
            {
                return null;
            }

            GameObject gameObject = _pool[objectType].poolList.Dequeue();
            gameObject.SetActive(true);
            _pool[objectType].poolList.Enqueue(gameObject);

            return gameObject;
        }

        public int GetPoolLengthOfType()
        {
            return _pool.Length;
        }

    }

}