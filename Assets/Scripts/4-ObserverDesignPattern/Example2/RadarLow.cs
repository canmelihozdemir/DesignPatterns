using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class RadarLow : RadarController
    {

        public RadarLow(CarSpeedSubject carSpeedSubject) : base(carSpeedSubject) 
        {
            _speedTarget = 5;
        }


        protected override void NotifySituation(int currentSpeed)
        {
            Debug.Log("Hız limitiniz: "+currentSpeed+" bölgenin hız limiti: "+ _speedTarget + " iyi yolculuklar..");
        }

    }
}

