using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Singleton
{
    public class SingletonDesignPattern<T> : MonoBehaviour where T : SingletonDesignPattern<T>
    {
        private static volatile T _instance = null;
        public static T Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = FindObjectOfType(typeof(T)) as T;
                }
                return _instance;
            }
        }
    }
    
}