using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class CarSpeedSubject
    {
        [SerializeField]private int _speed;
        public int Speed 
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
                Notify();
            }
        }
        private List<CarSpeedObserver> _observers = new List<CarSpeedObserver>();

        public void Attach(CarSpeedObserver carSpeedObserver) => _observers.Add(carSpeedObserver);
        public void Detach(CarSpeedObserver carSpeedObserver) => _observers.Remove(carSpeedObserver);

        public void Notify()
        {
            for (int i = 0; i < _observers.Count; i++)
            {
                _observers[i].OnNotify();
            }
        }
    }
}

