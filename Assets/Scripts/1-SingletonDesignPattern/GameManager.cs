using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Singleton
{
    public class GameManager : SingletonDesignPattern<GameManager>
    {
        private void Start()
        {
            Debug.Log("GameManager running");
        }
    }

}
