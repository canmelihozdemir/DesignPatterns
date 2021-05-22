using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class RadarController : CarSpeedObserver
    {
        protected int _speedTarget;

        public RadarController(CarSpeedSubject carSpeedSubject) : base(carSpeedSubject) { }
        protected virtual void NotifySituation(int currentSpeed) { }

        public override void OnNotify()
        {
            if (_subject.Speed> _speedTarget)
            {
                NotifySituation(_subject.Speed);
                _subject.Detach(this);
            }
        }

        

    }
}

