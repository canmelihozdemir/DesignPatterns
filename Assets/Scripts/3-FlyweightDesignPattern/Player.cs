using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Flyweight
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerData _playerData=null;
        private float _currentSpeed = 10;
        private int _currentHp = 100;

        private void Start()
        {
           _currentSpeed =_playerData.MaxSpeed;
        }
    }

}
