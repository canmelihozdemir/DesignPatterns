using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class RadarNormal : RadarController
    {

        public RadarNormal(CarSpeedSubject carSpeedSubject) : base(carSpeedSubject) 
        {
            _speedTarget = 10;
        }


        protected override void NotifySituation(int currentSpeed)
        {
            Debug.Log("Hız limitiniz: "+currentSpeed+" bölgenin hız limiti: "+ _speedTarget + " Lütfen hızınızı koruyunuz..");
        }

    }
}

