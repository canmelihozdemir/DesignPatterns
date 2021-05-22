using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class CarSpeedObserver
    {
        protected CarSpeedSubject _subject;
        public CarSpeedObserver(CarSpeedSubject carSpeedSubject)
        {
            _subject = carSpeedSubject;
            _subject.Attach(this);
        }

        public virtual void OnNotify() { }
    }
}

