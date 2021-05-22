using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class RadarSystem : MonoBehaviour
    {
        private CarSpeedSubject _carSpeedSubject = new CarSpeedSubject();
        private void Start()
        {
            var RadarLow = new RadarLow(_carSpeedSubject);
            var RadarNormal = new RadarNormal(_carSpeedSubject);
            var RadarHigh = new RadarHigh(_carSpeedSubject);
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _carSpeedSubject.Speed++;
            }
        }
    }

}
