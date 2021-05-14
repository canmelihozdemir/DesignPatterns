using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Singleton
{
    public class EventManager : SingletonDesignPattern<EventManager>
    {
        private void Start()
        {
            Debug.Log("EventManager running");
        }
    }

}
