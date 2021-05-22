using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class RadarHigh : RadarController
    {

        public RadarHigh(CarSpeedSubject carSpeedSubject) : base(carSpeedSubject) 
        {
            _speedTarget = 15;
        }

        protected override void NotifySituation(int currentSpeed)
        {
            Debug.Log("Hız limitiniz: "+currentSpeed+" bölgenin hız limiti: "+ _speedTarget + " radara yakalandınız!");
        }

    }
}

