using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public abstract class Subject : MonoBehaviour
    {
        private List<Observer> _observers = null;
        [SerializeField] private SubjectType _subjectType;
        public SubjectType SubjectType => _subjectType;

        private void Start()
        {
            ObserverManager.Instance.RegisterSubject(this);
        }

        public void RegisterObserver(Observer observer)
        {
            if (_observers==null)
            {
                _observers = new List<Observer>();
            }
            _observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(NotificationType notificationType)
        {
            foreach (var observer in _observers)
            {
                observer.OnNotify(notificationType);
            }
        }
    }

}
